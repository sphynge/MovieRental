using System.Collections.Generic;

namespace MovieRental.Tests.Models
{
    internal class StatementBuilder
    {
        private string customerName;
        private List<string> movieNames;
        private List<double> amounts;
        private double totalAmount;
        private int frequentRenterPoints;

        public StatementBuilder()
        {
            movieNames = new List<string>();
            amounts = new List<double>();
        }

        public StatementBuilder CustomerName(string customerName)
        {
            this.customerName = customerName;
            return this;
        }

        public StatementBuilder Movie(string movieName, double amount)
        {
            movieNames.Add(movieName);
            amounts.Add(amount);
            return this;
        }

        public StatementBuilder TotalAmount(double totalAmount)
        {
            this.totalAmount = totalAmount;
            return this;
        }

        public StatementBuilder FrequentRenterPoints(int frequentRenterPoints)
        {
            this.frequentRenterPoints = frequentRenterPoints;
            return this;
        }

        public string Build()
        {
            var result = "\nRental Record for " + customerName + "\n";
            for (var i = 0; i < movieNames.Count; i++)
            {
                result += "\t" + movieNames[i] + "\t" + amounts[i] + "\n";
            }

            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";
            return result;
        }
    }
}
