using MovieRental.Models;

namespace MovieRental.Tests.Models
{
    internal class RentalBuilder
    {
        private Movie movie;
        private int daysRented;

        public RentalBuilder Movie(Movie movie)
        {
            this.movie = movie;
            return this;
        }

        public RentalBuilder DaysRented(int daysRented)
        {
            this.daysRented = daysRented;
            return this;
        }

        public Rental Build()
        {
            return new Rental(movie, daysRented);
        }
    }
}
