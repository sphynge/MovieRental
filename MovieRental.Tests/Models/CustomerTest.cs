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
            var customer = new CustomerBuilder().Build();
            var expected = new StatementBuilder()
                .WithFrequentRenterPoints(0)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }


        [TestMethod]
        public void RegularRental1Day()
        {
            var rental = RentalBuilder.Children(1);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void RegularRental2Days()
        {
            var rental = RentalBuilder.Children(2);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void RegularRental3Days()
        {
            var rental = RentalBuilder.Children(3);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental1Day()
        {
            var rental = RentalBuilder.NewRelease(1);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental2Days()
        {
            var rental = RentalBuilder.NewRelease(2);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(2)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental3Days()
        {
            var rental = RentalBuilder.NewRelease(3);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(2)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental1Day()
        {
            var rental = RentalBuilder.Children(1);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental3Days()
        {
            var rental = RentalBuilder.Children(3);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                .WithFrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental4Days()
        {
            var rental = RentalBuilder.Children(4);
            var customer = new CustomerBuilder().WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithRental(rental)
                    .WithFrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void EachTypeRental10Days()
        {
            var regularRental = RentalBuilder.Regular(10);
            var newReleaseRental = RentalBuilder.NewRelease(10);
            var childrensRental = RentalBuilder.Children(10);

            var rentals = new List<Rental>
            {
                regularRental,
                newReleaseRental,
                childrensRental
            };

            var customer = new CustomerBuilder()
                    .WithRental(regularRental)
                    .WithRental(newReleaseRental)
                    .WithRental(childrensRental)
                    .Build();

            var expected = new StatementBuilder()
                .WithRentals(rentals)
                .WithFrequentRenterPoints(4)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }
    }
}
