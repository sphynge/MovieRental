using MovieRental.Models;

namespace MovieRental.Tests.Models
{
    internal class RentalBuilder
    {
        private Movie _movie;
        private int _daysRented;

        public RentalBuilder WithMovie(Movie movie)
        {
            this._movie = movie;
            return this;
        }

        public RentalBuilder WithDaysRented(int daysRented)
        {
            this._daysRented = daysRented;
            return this;
        }

        public Rental Build()
        {
            return new Rental(_movie, _daysRented);
        }

        public static Rental Regular(int daysRented)
        {
            return new Rental(MovieBuilder.Regular(), daysRented);
        }

        public static Rental NewRelease(int daysRented)
        {
            return new Rental(MovieBuilder.NewRelease(), daysRented);
        }

        public static Rental Children(int daysRented)
        {
            return new Rental(MovieBuilder.Children(), daysRented);
        }
    }
}
