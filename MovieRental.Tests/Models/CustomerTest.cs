using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieRental.Tests.Models
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void WithoutRentals()
        {
            var customerName = "customerName";
            var customer = new CustomerBuilder()
                .WithName(customerName)
                .Build();

            var expected = new StatementBuilder()
                .WithCustomerName(customerName)
                .WithFrequentRenterPoints(0)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }


        [TestMethod]
        public void RegularRental1Day()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Regular().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(1).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().WithName(customerName).WithRental(rental).Build();

            var expected = new StatementBuilder()
                    .WithCustomerName(customerName)
                    .WithMovieCharge(2)
                    .WithFrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void RegularRental2Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Regular().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(2).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().WithName(customerName).WithRental(rental).Build();

            var expected = new StatementBuilder()
                    .WithCustomerName(customerName)
                    .WithMovieCharge(2)
                    .WithFrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void RegularRental3Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Regular().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(3).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().WithName(customerName).WithRental(rental).Build();

            var expected = new StatementBuilder()
                    .WithCustomerName(customerName)
                    .WithMovieCharge(3.5)
                    .WithFrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental1Day()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().NewRelease().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(1).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().WithName(customerName).WithRental(rental).Build();

            var expected = new StatementBuilder()
                    .WithCustomerName(customerName)
                    .WithMovieCharge(3)
                    .WithFrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental2Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().NewRelease().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(2).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().WithName(customerName).WithRental(rental).Build();

            var expected = new StatementBuilder()
                    .WithCustomerName(customerName)
                    .WithMovieCharge(6)
                    .WithFrequentRenterPoints(2)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental3Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().NewRelease().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(3).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().WithName(customerName).WithRental(rental).Build();

            var expected = new StatementBuilder()
                    .WithCustomerName(customerName)
                    .WithMovieCharge(9)
                    .WithFrequentRenterPoints(2)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental1Day()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Children().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(1).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().WithName(customerName).WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithCustomerName(customerName)
                .WithMovieCharge(1.5)
                .WithFrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental3Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Children().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(3).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().WithName(customerName).WithRental(rental).Build();

            var expected = new StatementBuilder()
                .WithCustomerName(customerName)
                .WithMovieCharge(1.5)
                .WithFrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental4Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Children().Build();
            var rental = new RentalBuilder().WithMovie(movie).WithDaysRented(4).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().WithName(customerName).WithRental(rental).Build();

            var expected = new StatementBuilder()
                    .WithCustomerName(customerName)
                    .WithMovieCharge(3)
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

            var customerName = "customerName";
            var customer = new CustomerBuilder()
                    .WithName(customerName)
                    .WithRental(regularRental)
                    .WithRental(newReleaseRental)
                    .WithRental(childrensRental)
                    .Build();

            var expected = new StatementBuilder()
                    .WithCustomerName(customerName)
                    .WithMovie(regularMovieName, 14)
                    .WithMovie(newReleaseMovieName, 30)
                    .WithMovie(childrensMovieName, 12)
                    .WithFrequentRenterPoints(4)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }
    }
}
