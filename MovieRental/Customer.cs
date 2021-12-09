using System.Collections.Generic;

namespace MovieRental
{
    public class Customer
    {
        private readonly string _name;
        private readonly List<Rental> _rentals;

        public Customer(string name)
        {
            this._name = name;
            this._rentals = new List<Rental>();
        }

        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }

        public string GetName()
        {
            return _name;
        }

        public string Statement()
        {
            var totalAmount = 0.0;
            var frequentRenterPoints = 0;
            var result = "\nRental Record for " + GetName() + "\n";

            foreach (var rental in _rentals)
            {
                var thisAmount = AmountFor(rental);

                frequentRenterPoints++;

                if ((rental.Movie.PriceCode == Movie.NewRelease) && rental.DaysRented > 1)
                    frequentRenterPoints++;

                result += "\t" + rental.Movie.Title + "\t" + thisAmount + "\n";
                totalAmount += thisAmount;
            }

            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";

            return result;
        }

        private static double AmountFor(Rental rental)
        {
            double thisAmount = 0;

            switch (rental.Movie.PriceCode)
            {
                case Movie.Regular:
                    thisAmount += 2;
                    if (rental.DaysRented > 2)
                        thisAmount += (rental.DaysRented - 2) * 1.5;
                    break;
                case Movie.NewRelease:
                    thisAmount += rental.DaysRented * 3;
                    break;
                case Movie.Children:
                    thisAmount += 1.5;
                    if (rental.DaysRented > 3)
                        thisAmount += (rental.DaysRented - 3) * 1.5;
                    break;
            }

            return thisAmount;
        }
    }
}