namespace MovieRental
{
    public class Movie
    {
        private int _priceCode;
        public const int Children = 2;
        public const int NewRelease = 1;
        public const int Regular = 0;

        public string Title { get; set; }

        public void SetPriceCode(int value)
        {
            _priceCode = value;
        }

        public int GetPriceCode()
        {
            return _priceCode;
        }

        public Movie(string title, int priceCode)
        {
            Title = title;
            SetPriceCode(priceCode);
        }

        public double GetCharge(int daysRented)
        {
            double result = 0;

            switch (this.GetPriceCode())
            {
                case Movie.Regular:
                    result += 2;
                    if (daysRented > 2)
                        result += (daysRented - 2) * 1.5;
                    break;

                case Movie.NewRelease:
                    result += daysRented * 3;
                    break;

                case Movie.Children:
                    result += 1.5;
                    if (daysRented > 3)
                        result += (daysRented - 3) * 1.5;
                    break;
            }

            return result;
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return (GetPriceCode() == NewRelease && daysRented > 1) ? 2 : 1;
        }
    }
}