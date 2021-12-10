using System.Collections.Generic;
using System.Linq;
using MovieRental.Models;

namespace MovieRental.Tests.Models
{
    internal class StatementBuilder
    {
        private readonly string _customerName;
        private readonly List<string> _movieNames;
        private readonly List<double> _amounts;
        private int _frequentRenterPoints;

        public StatementBuilder()
        {
            _movieNames = new List<string>();
            _amounts = new List<double>();
            _customerName = CustomerBuilder.DefaultCustomerName;
        }

        public StatementBuilder WithRental(Rental rental)
        {
            _movieNames.Add(rental.GetTitle());
            _amounts.Add(rental.GetCharge());
            return this;
        }

        public StatementBuilder WithRentals(IEnumerable<Rental> rentals)
        {
            foreach (var rental in rentals)
            {
                _movieNames.Add(rental.GetTitle());
                _amounts.Add(rental.GetCharge());
            }
            return this;
        }

        public StatementBuilder WithFrequentRenterPoints(int frequentRenterPoints)
        {
            this._frequentRenterPoints = frequentRenterPoints;
            return this;
        }

        public string Build()
        {
            var result = $"\nRental Record for {_customerName}\n";
            for (var i = 0; i < _movieNames.Count; i++)
            {
                result += $"\t{_movieNames[i]}\t{_amounts[i]}\n";
            }

            result += $"Amount owed is {GetTotalAmount()}\n";
            result += $"You earned {_frequentRenterPoints} frequent renter points\n";
            return result;
        }

        private double GetTotalAmount() => _amounts.Sum();
    }
}
