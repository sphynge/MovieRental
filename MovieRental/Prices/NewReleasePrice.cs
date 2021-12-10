namespace MovieRental.Prices
{
    public class NewReleasePrice : Price
    {
        private const double Charge = 3;
        //private const double ChargeExtra = 1;
        private const double DaysRentedThreshold = 1;
        private const int FrequentRenterPoints = 2;
        private const int DefaultRenterPoints = 1;

        public override double GetCharge(int daysRented)
        {
            return daysRented * Charge;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            return (daysRented > DaysRentedThreshold) ? FrequentRenterPoints : DefaultRenterPoints;
        }
    }
}
