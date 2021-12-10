namespace MovieRental.Prices
{
    public class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NewRelease;
        }
    }
}
