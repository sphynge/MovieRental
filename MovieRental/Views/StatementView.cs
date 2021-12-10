using System.Collections.Generic;
using MovieRental.Models;

namespace MovieRental.Views
{
    public class StatementView
    {
        private readonly string _customerName;
        private readonly double _totalAmount;
        private readonly int _totalFrequentRenterPoints;
        private readonly IEnumerable<Rental> _rentals;

        public StatementView(
            string customerName,
            double totalAmount,
            int totalFrequentRenterPoints,
            IEnumerable<Rental> rentals)
        {
            _customerName = customerName;
            _totalAmount = totalAmount;
            _totalFrequentRenterPoints = totalFrequentRenterPoints;
            _rentals = rentals;
        }

        public string Display()
        {
            var result = $"\nRental Record for {_customerName}\n";

            foreach (var rental in _rentals)
                result += new RentalView(rental).Display();

            result += $"Amount owed is {_totalAmount}\n";
            result += $"You earned {_totalFrequentRenterPoints} frequent renter points\n";

            return result;
        }
    }
}