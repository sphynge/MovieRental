using System.Collections.Generic;

namespace MovieRental.Tests
{
    internal class CustomerBuilder
    {
        private string name;
        private List<Rental> rentals;

        public CustomerBuilder()
        {
            rentals = new List<Rental>();
        }

        public CustomerBuilder Name(string name)
        {
            this.name = name;
            return this;
        }

        public CustomerBuilder Rental(Rental rental)
        {
            rentals.Add(rental);
            return this;
        }

        public Customer Build()
        {
            var customer = new Customer(name);
            foreach (var rental in rentals)
            {
                customer.AddRental(rental);
            }
            return customer;
        }
    }
}
