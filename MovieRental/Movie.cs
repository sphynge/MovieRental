using MovieRental.Prices;

namespace MovieRental
{
    public class Movie
    {
        private int _priceCode;
        public const int Children = 2;
        public const int NewRelease = 1;
        public const int Regular = 0;

        public string Title { get; set; }
        public Price _price;

        public void SetPriceCode(int priceCode)
        {
            switch (priceCode)
            {
                case Movie.Children:
                    _price = new ChildrenPrice();
                    break;

                case Movie.NewRelease:
                    _price = new NewReleasePrice();
                    break;

                default:
                    _price = new RegularPrice();
                    break;
            }
        }

        public int GetPriceCode()
        {
            return _price.GetPriceCode();
        }

        public Movie(string title, int priceCode)
        {
            Title = title;
            SetPriceCode(priceCode);
        }

        public double GetCharge(int daysRented)
        {
            return _price.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return (GetPriceCode() == NewRelease && daysRented > 1) ? 2 : 1;
        }
    }
}