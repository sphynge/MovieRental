using MovieRental.Models;

namespace MovieRental.Views
{
    public class RentalView
    {
        private readonly Rental _rental;

        public RentalView(Rental rental)
        {
            _rental = rental;
        }

        public string Display()
        {
            return "\t" + _rental.GetTitle() + "\t" + _rental.GetCharge() + "\n";
        }
    }
}
