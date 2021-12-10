﻿namespace MovieRental.Prices
{
    public class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NewRelease;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }
    }
}
