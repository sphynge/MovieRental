using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental.Models.Prices;

namespace MovieRental.Tests.Models.Prices
{

    [TestClass]
    public class ChildrenPriceTests
    {
        private readonly Price _price;

        public ChildrenPriceTests()
        {
            _price = new ChildrenPrice();
        }

        [TestMethod]
        public void AmountFor1Day()
        {
            const int daysRented = 1;
            const double expectedAmount = 1.5;

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
            const double expectedAmount = 1.5;

            Assert.AreEqual(expectedAmount, _price.GetCharge(daysRented));
        }

        [TestMethod]
        public void PointsFor2Day()
        {
            const int daysRented = 2;
            const int expectedPoints = 1;

            Assert.AreEqual(expectedPoints, _price.GetFrequentRenterPoints(daysRented));
        }

        [TestMethod]
        public void AmountFor4Day()
        {
            const int daysRented = 4;
            const double expectedAmount = 3;

            Assert.AreEqual(expectedAmount, _price.GetCharge(daysRented));
        }

        [TestMethod]
        public void PointsFor4Day()
        {
            const int daysRented = 4;
            const int expectedPoints = 1;

            Assert.AreEqual(expectedPoints, _price.GetFrequentRenterPoints(daysRented));
        }

    }
}