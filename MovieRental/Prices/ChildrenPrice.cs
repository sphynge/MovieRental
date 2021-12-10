namespace MovieRental.Prices
{
    public class ChildrenPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Children;
        }
    }
}
