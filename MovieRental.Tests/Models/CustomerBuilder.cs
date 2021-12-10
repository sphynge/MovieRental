using System.Collections.Generic;
using MovieRental.Models;

namespace MovieRental.Tests.Models
{
    internal class CustomerBuilder
    {
        private string _name;
        private readonly List<Rental> _rentals;

        public CustomerBuilder()
        {
            _rentals = new List<Rental>();
        }

        public CustomerBuilder Name(string name)
        {
            this._name = name;
            return this;
        }

        public CustomerBuilder Rental(Rental rental)
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
