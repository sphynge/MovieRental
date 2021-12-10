namespace MovieRental
{
    public class Rental
    {
        public Movie Movie { get; set; }
        public int DaysRented { get; set; }

        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }

        public double GetCharge()
        {
            double result = 0;

            switch (Movie.PriceCode)
            {
                case Movie.Regular:
                    result += 2;
                    if (DaysRented > 2)
                        result += (DaysRented - 2) * 1.5;
                    break;

                case Movie.NewRelease:
                    result += DaysRented * 3;
                    break;

                case Movie.Children:
                    result += 1.5;
                    if (DaysRented > 3)
                        result += (DaysRented - 3) * 1.5;
                    break;
            }

            return result;
        }

        public int GetFrequentRenterPoints()
        {
            return (Movie.PriceCode == Movie.NewRelease && DaysRented > 1) ? 2 : 1;
        }
    }
}