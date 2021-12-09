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
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            string result = "\nRental Record for " + GetName() + "\n";

            foreach (Rental each in _rentals)
            {
                double thisAmount = 0;

                //determine amounts for each line
                switch (each.Movie.PriceCode)
                {
                    case Movie.Regular:
                        thisAmount += 2;
                        if (each.DaysRented > 2)
                            thisAmount += (each.DaysRented - 2) * 1.5;
                        break;
                    case Movie.NewRelease:
                        thisAmount += each.DaysRented * 3;
                        break;
                    case Movie.Children:
                        thisAmount += 1.5;
                        if (each.DaysRented > 3)
                            thisAmount += (each.DaysRented - 3) * 1.5;
                        break;
                }

                // add frequent renter points
                frequentRenterPoints++;
                // add bonus for a two day new release rental
                if ((each.Movie.PriceCode == Movie.NewRelease) && each.DaysRented > 1)
                    frequentRenterPoints++;

                // show figures for this rental
                result += "\t" + each.Movie.Title + "\t" + thisAmount.ToString() + "\n";
                totalAmount += thisAmount;
            }

            // add footer lines
            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() + " frequent renter points\n";

            return result;
        }
    }
}

