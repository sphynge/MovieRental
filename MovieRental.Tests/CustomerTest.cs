using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieRental.Tests
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void WithoutRentals()
        {
            var customer = new CustomerBuilder().Build();
            var expected = new StatementBuilder()
                .TotalAmount(0)
                .FrequentRenterPoints(0)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void RegularRental1Day()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Title(movieName).PriceCode(Movie.Regular).Build();
            var rental = new RentalBuilder().Movie(movie).DaysRented(1).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().Name(customerName).Rental(rental).Build();

            var expected = new StatementBuilder()
                    .CustomerName(customerName)
                    .Movie(movieName, 2)
                    .TotalAmount(2)
                    .FrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void RegularRental2Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Title(movieName).PriceCode(Movie.Regular).Build();
            var rental = new RentalBuilder().Movie(movie).DaysRented(2).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().Name(customerName).Rental(rental).Build();

            var expected = new StatementBuilder()
                    .CustomerName(customerName)
                    .Movie(movieName, 2)
                    .TotalAmount(2)
                    .FrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void RegularRental3Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Title(movieName).PriceCode(Movie.Regular).Build();
            var rental = new RentalBuilder().Movie(movie).DaysRented(3).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().Name(customerName).Rental(rental).Build();

            var expected = new StatementBuilder()
                    .CustomerName(customerName)
                    .Movie(movieName, 3.5)
                    .TotalAmount(3.5)
                    .FrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental1Day()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Title(movieName).PriceCode(Movie.NewRelease).Build();
            var rental = new RentalBuilder().Movie(movie).DaysRented(1).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().Name(customerName).Rental(rental).Build();

            var expected = new StatementBuilder()
                    .CustomerName(customerName)
                    .Movie(movieName, 3)
                    .TotalAmount(3)
                    .FrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental2Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Title(movieName).PriceCode(Movie.NewRelease).Build();
            var rental = new RentalBuilder().Movie(movie).DaysRented(2).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().Name(customerName).Rental(rental).Build();

            var expected = new StatementBuilder()
                    .CustomerName(customerName)
                    .Movie(movieName, 6)
                    .TotalAmount(6)
                    .FrequentRenterPoints(2)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void NewReleaseRental3Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Title(movieName).PriceCode(Movie.NewRelease).Build();
            var rental = new RentalBuilder().Movie(movie).DaysRented(3).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().Name(customerName).Rental(rental).Build();

            var expected = new StatementBuilder()
                    .CustomerName(customerName)
                    .Movie(movieName, 9)
                    .TotalAmount(9)
                    .FrequentRenterPoints(2)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental1Day()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Title(movieName).PriceCode(Movie.Children).Build();
            var rental = new RentalBuilder().Movie(movie).DaysRented(1).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().Name(customerName).Rental(rental).Build();

            var expected = new StatementBuilder()
                .CustomerName(customerName)
                .Movie(movieName, 1.5)
                .TotalAmount(1.5)
                .FrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental3Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Title(movieName).PriceCode(Movie.Children).Build();
            var rental = new RentalBuilder().Movie(movie).DaysRented(3).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().Name(customerName).Rental(rental).Build();

            var expected = new StatementBuilder()
                .CustomerName(customerName)
                .Movie(movieName, 1.5)
                .TotalAmount(1.5)
                .FrequentRenterPoints(1)
                .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void ChildrenRental4Days()
        {
            var movieName = "movieName";
            var movie = new MovieBuilder().Title(movieName).PriceCode(Movie.Children).Build();
            var rental = new RentalBuilder().Movie(movie).DaysRented(4).Build();
            var customerName = "customerName";
            var customer = new CustomerBuilder().Name(customerName).Rental(rental).Build();

            var expected = new StatementBuilder()
                    .CustomerName(customerName)
                    .Movie(movieName, 3)
                    .TotalAmount(3)
                    .FrequentRenterPoints(1)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }

        [TestMethod]
        public void EachTypeRental10Days()
        {
            var regularMovieName = "regularMovieName";
            var regularMovie = new MovieBuilder().Title(regularMovieName).PriceCode(Movie.Regular).Build();
            var regularRental = new RentalBuilder().Movie(regularMovie).DaysRented(10).Build();

            var newReleaseMovieName = "newReleaseMovieName";
            var newReleaseMovie = new MovieBuilder().Title(newReleaseMovieName).PriceCode(Movie.NewRelease).Build();
            var newReleaseRental = new RentalBuilder().Movie(newReleaseMovie).DaysRented(10).Build();

            var childrensMovieName = "childrensMovieName";
            var childrensMovie = new MovieBuilder().Title(childrensMovieName).PriceCode(Movie.Children).Build();
            var childrensRental = new RentalBuilder().Movie(childrensMovie).DaysRented(10).Build();

            var customerName = "customerName";
            var customer = new CustomerBuilder()
                    .Name(customerName)
                    .Rental(regularRental)
                    .Rental(newReleaseRental)
                    .Rental(childrensRental)
                    .Build();

            var expected = new StatementBuilder()
                    .CustomerName(customerName)
                    .Movie(regularMovieName, 14)
                    .Movie(newReleaseMovieName, 30)
                    .Movie(childrensMovieName, 12)
                    .TotalAmount(56)
                    .FrequentRenterPoints(4)
                    .Build();

            Assert.AreEqual(expected, customer.Statement());
        }
    }
}
