namespace MovieRental
{
    public class Rental
    {
        private readonly Movie _movie;
        public int DaysRented { get; set; }

        public Rental(Movie movie, int daysRented)
        {
            _movie = movie;
            DaysRented = daysRented;
        }

        public double GetCharge()
        {
            return _movie.GetCharge(DaysRented);
        }

        public int GetFrequentRenterPoints()
        {
            return _movie.GetFrequentRenterPoints(DaysRented);
        }

        public string GetTitle() => _movie.GetTitle();
    }
}