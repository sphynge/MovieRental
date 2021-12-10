using MovieRental.Prices;

namespace MovieRental
{
    public class Movie
    {
        public const int Children = 2;
        public const int NewRelease = 1;
        public const int Regular = 0;

        public string Title { get; set; }
        private readonly Price _price;

        public Movie(string title, Price price)
        {
            Title = title;
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
    }
}