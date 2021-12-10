using System.Collections.Generic;
using MovieRental.Models;

namespace MovieRental.Tests.Models
{
    internal class CustomerBuilder
    {
        public const string DefaultCustomerName = "customerName";

        private readonly string _name;
        private readonly List<Rental> _rentals;

        public CustomerBuilder()
        {
            this._name = DefaultCustomerName;
            this._rentals = new List<Rental>();
        }

        public CustomerBuilder WithRental(Rental rental)
        {
            _rentals.Add(rental);
            return this;
        }

        public Customer Build()
        {
            var customer = new Customer(_name);
            foreach (var rental in _rentals)
            {
                customer.AddRental(rental);
            }
            return customer;
        }
    }
}
