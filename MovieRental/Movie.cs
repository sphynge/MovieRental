using MovieRental.Prices;

namespace MovieRental
{
    public class Movie
    {
        private readonly string _title;
        private readonly Price _price;

        public Movie(string title, Price price)
        {
            _title = title;
            _price = price;
        }

        public double GetCharge(int daysRented)
        {
            return _price.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return _price.GetFrequentRenterPoints(daysRented);
        }

        public string GetTitle() => _title;
    }
}