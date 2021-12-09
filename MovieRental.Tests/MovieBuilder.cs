namespace MovieRental.Tests
{
    internal class MovieBuilder
    {
        private string title;
        private int priceCode;

        public MovieBuilder()
        {
            title = "movieName";
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
            return new Movie(title, priceCode);
        }
    }
}
