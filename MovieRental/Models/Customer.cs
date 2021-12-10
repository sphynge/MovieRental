using System.Collections.Generic;
using MovieRental.Views;

namespace MovieRental.Models
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
            return new StatementView(
                GetName(), 
                GetTotalAmount(), 
                GetTotalFrequentRenterPoints(), 
                _rentals)
                .Display();
        }

        private double GetTotalAmount()
        {
            var result = 0.0;

            foreach (var rental in _rentals)
                result += rental.GetCharge();

            return result;
        }

        private int GetTotalFrequentRenterPoints()
        {
            var result = 0;

            foreach (var rental in _rentals)
                result += rental.GetFrequentRenterPoints();

            return result;
        }
    }
}