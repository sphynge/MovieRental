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
                var thisAmount = rental.GetCharge();

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
    }
}