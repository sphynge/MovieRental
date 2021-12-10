using MovieRental.Models;

namespace MovieRental.Tests.Models
{
    internal static class RentalBuilder
    {

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
