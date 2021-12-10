using MovieRental.Prices;

namespace MovieRental.Tests
{
    internal class MovieBuilder
    {
        private string title;
        private Price price;
        private int priceCode;

        public MovieBuilder()
        {
            title = "movieName";
        }

        public MovieBuilder NewRelease()
        {
            price = new NewReleasePrice();
            return this;
        }

        public MovieBuilder Children()
        {
            price = new ChildrenPrice();
            return this;
        }
        public MovieBuilder Regular()
        {
            price = new RegularPrice();
            return this;
        }

        public MovieBuilder Title(string title)
        {
            this.title = title;
            return this;
        }

        public MovieBuilder PriceCode(int priceCode)
        {
            this.priceCode = priceCode;
            return this;
        }

        public Movie Build()
        {
            return new Movie(title, price);
        }
    }
}
