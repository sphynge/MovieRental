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
            var rental = new RentalBuilder()
                .WithMovie(MovieBuilder.BuildRegular())
                .WithDaysRented(1)
                .Build();

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
            var rental = new RentalBuilder()
                .WithMovie(MovieBuilder.BuildRegular())
                .WithDaysRented(2)
                .Build();

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
            var rental = new RentalBuilder()
                .WithMovie(MovieBuilder.BuildRegular())
                .WithDaysRented(3)
                .Build();

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
            var rental = new RentalBuilder()
                .WithMovie(MovieBuilder.BuildNewRelease())
                .WithDaysRented(1)
                .Build();

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
            var rental = new RentalBuilder()
                .WithMovie(MovieBuilder.BuildNewRelease())
                .WithDaysRented(2)
                .Build();

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
            var rental = new RentalBuilder()
                .WithMovie(MovieBuilder.BuildNewRelease())
                .WithDaysRented(3)
                .Build();

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
            var rental = new RentalBuilder()
                .WithMovie(MovieBuilder.BuildChildren())
                .WithDaysRented(1)
                .Build();
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
            var rental = new RentalBuilder()
                .WithMovie(MovieBuilder.BuildChildren())
                .WithDaysRented(3)
                .Build();

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
            var rental = new RentalBuilder()
                .WithMovie(MovieBuilder.BuildChildren())
                .WithDaysRented(4)
                .Build();

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
            var regularRental = new RentalBuilder().WithMovie(MovieBuilder.BuildRegular()).WithDaysRented(10).Build();
            var newReleaseRental = new RentalBuilder().WithMovie(MovieBuilder.BuildNewRelease()).WithDaysRented(10).Build();
            var childrensRental = new RentalBuilder().WithMovie(MovieBuilder.BuildChildren()).WithDaysRented(10).Build();

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
