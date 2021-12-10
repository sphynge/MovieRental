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
            var movie = new MovieBuilder().Regular().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(1).Build();
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
            var movie = new MovieBuilder().Regular().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(2).Build();

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
            var movie = new MovieBuilder().Regular().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(3).Build();
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
            var movie = new MovieBuilder().NewRelease().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(1).Build();
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
            var movie = new MovieBuilder().NewRelease().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(2).Build();
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
            var movie = new MovieBuilder().NewRelease().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(3).Build();
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
            var movie = new MovieBuilder().Children().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(1).Build();
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
            var movie = new MovieBuilder().Children().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(3).Build();
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
            var movie = new MovieBuilder().Children().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(4).Build();
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
            var regularMovieName = "regularMovieName";
            var regularMovie = new MovieBuilder().WithTitle(regularMovieName).Regular().Build();
            var regularRental = new RentalBuilder().WithMovie(regularMovie).WithDaysRented(10).Build();

            var newReleaseMovieName = "newReleaseMovieName";
            var newReleaseMovie = new MovieBuilder().WithTitle(newReleaseMovieName).NewRelease().Build();
            var newReleaseRental = new RentalBuilder().WithMovie(newReleaseMovie).WithDaysRented(10).Build();

            var childrensMovieName = "childrensMovieName";
            var childrensMovie = new MovieBuilder().WithTitle(childrensMovieName).Children().Build();
            var childrensRental = new RentalBuilder().WithMovie(childrensMovie).WithDaysRented(10).Build();

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
