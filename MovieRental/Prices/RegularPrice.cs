﻿namespace MovieRental.Prices
{
    public class RegularPrice : Price
    {
        public override double GetCharge(int daysRented)
        {
            var result = 2.0;
            if (daysRented > 2)
                result += (daysRented - 2) * 1.5;
            return result;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }
}
