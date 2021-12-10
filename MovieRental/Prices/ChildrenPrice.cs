namespace MovieRental.Prices
{
    public class ChildrenPrice : Price
    {
        private const double Charge = 1.5;
        private const double ChargeExtra = 1.5;
        private const double DaysRentedThreshold = 3;
        private const int DefaultRenterPoints = 1;

        public override double GetCharge(int daysRented)
        {
            var result = Charge;

            if (daysRented > DaysRentedThreshold)
                result += (daysRented - DaysRentedThreshold) * ChargeExtra;

            return result;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            return DefaultRenterPoints;
        }
    }
}
