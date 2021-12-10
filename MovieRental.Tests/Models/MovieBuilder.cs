using MovieRental.Models;
using MovieRental.Models.Prices;

namespace MovieRental.Tests.Models
{
    internal static class MovieBuilder
    {

        public static Movie Children()
        {
            return new Movie("Children movie", new ChildrenPrice());
        }

        public static Movie Regular()
        {
            return new Movie("Regular movie", new RegularPrice());
        }

        public static Movie NewRelease()
        {
            return new Movie("New release movie", new NewReleasePrice());
        }
    }
}
