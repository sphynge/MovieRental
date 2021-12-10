namespace MovieRental
{
    public class Movie
    {
        public const int Children = 2;
        public const int NewRelease = 1;
        public const int Regular = 0;

        public string Title { get; set; }
        public int PriceCode { get; set; }

        public Movie(string title, int priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public double GetCharge(int daysRented)
        {
            double result = 0;

            switch (this.PriceCode)
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
    }
}