using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental.Models;

namespace MovieRental.Tests.Models
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void WithoutRentals()
        {
            const int expectedPoints = 0;

            var customer = new CustomerBuilder().Build();
            var expected = new StatementBuilder()
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void EachTypeRental10Days()
        {
            const int daysRented = 10;
            const int expectedPoints = 4;

            var rentals = new List<Rental>
            {
                RentalBuilder.Regular(daysRented),
                RentalBuilder.NewRelease(daysRented),
                RentalBuilder.Children(daysRented)
            };

            var customer = new CustomerBuilder()
                    .WithRentals(rentals)
                    .Build();

            var expected = new StatementBuilder()
                .WithRentals(rentals)
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }
    }
}