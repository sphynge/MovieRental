using MovieRental.Models;
using MovieRental.Models.Prices;

namespace MovieRental.Tests.Models
{
    internal class MovieBuilder
    {
        public const string DefaultMovieName = "movieName";

        private string _title;
        private Price _price;

        public MovieBuilder()
        {
            _title = DefaultMovieName;
        }

        public MovieBuilder NewRelease()
        {
            _price = new NewReleasePrice();
            return this;
        }

        public MovieBuilder Children()
        {
            _price = new ChildrenPrice();
            return this;
        }
        
        public MovieBuilder Regular()
        {
            _price = new RegularPrice();
            return this;
        }

        public MovieBuilder WithTitle(string title)
        {
            this._title = title;
            return this;
        }

        public Movie Build()
        {
            return new Movie(_title, _price);
        }
    }
}
