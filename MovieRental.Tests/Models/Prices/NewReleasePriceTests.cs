using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental.Models.Prices;

namespace MovieRental.Tests.Models.Prices
{

    [TestClass]
    public class NewReleasePriceTests
    {
        private readonly Price _price;

        public NewReleasePriceTests()
        {
            _price = new NewReleasePrice();
        }

        [TestMethod]
        public void AmountFor1Day()
        {
            const int daysRented = 1;
            const double expectedAmount = 3;

            Assert.AreEqual(expectedAmount, _price.GetCharge(daysRented));
        }

        [TestMethod]
        public void PointsFor1Day()
        {
            const int daysRented = 1;
            const int expectedPoints = 1;

            Assert.AreEqual(expectedPoints, _price.GetFrequentRenterPoints(daysRented));
        }

        [TestMethod]
        public void AmountFor2Day()
        {
            const int daysRented = 2;
            const double expectedAmount = 6;

            Assert.AreEqual(expectedAmount, _price.GetCharge(daysRented));
        }

        [TestMethod]
        public void PointsFor2Day()
        {
            const int daysRented = 2;
            const int expectedPoints = 2;

            Assert.AreEqual(expectedPoints, _price.GetFrequentRenterPoints(daysRented));
        }

        [TestMethod]
        public void AmountFor3Day()
        {
            const int daysRented = 3;
            const double expectedAmount = 9;

            Assert.AreEqual(expectedAmount, _price.GetCharge(daysRented));
        }

        [TestMethod]
        public void PointsFor3Day()
        {
            const int daysRented = 3;
            const int expectedPoints = 2;

            Assert.AreEqual(expectedPoints, _price.GetFrequentRenterPoints(daysRented));
        }

    }
}