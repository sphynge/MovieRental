namespace MovieRental.Prices
{
    public abstract class Price
    {
        public abstract double GetCharge(int daysRented);

        public abstract int GetFrequentRenterPoints(int daysRented);
    }
}
