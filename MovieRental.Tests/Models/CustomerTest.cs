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
        public void RegularRental1Day()
        {
            const int daysRented = 1;
            const int expectedPoints = 1;

            var rental = RentalBuilder.Regular(daysRented);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void RegularRental2Days()
        {
            const int daysRented = 2;
            const int expectedPoints = 1;

            var rental = RentalBuilder.Regular(daysRented);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void RegularRental3Days()
        {
            const int daysRented = 3;
            const int expectedPoints = 1;

            var rental = RentalBuilder.Regular(daysRented);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental1Day()
        {
            const int daysRented = 1;
            const int expectedPoints = 1;

            var rental = RentalBuilder.NewRelease(daysRented);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental2Days()
        {
            const int daysRented = 2;
            const int expectedPoints = 2;

            var rental = RentalBuilder.NewRelease(daysRented);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental3Days()
        {
            const int daysRented = 3;
            const int expectedPoints = 2;

            var rental = RentalBuilder.NewRelease(daysRented);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental1Day()
        {
            const int daysRented = 1;
            const int expectedPoints = 1;

            var rental = RentalBuilder.Children(daysRented);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental3Days()
        {
            const int daysRented = 3;
            const int expectedPoints = 1;

            var rental = RentalBuilder.Children(daysRented);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(expectedPoints)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental4Days()
        {
            const int daysRented = 4;
            const int expectedPoints = 1;

            var rental = RentalBuilder.Children(daysRented);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
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