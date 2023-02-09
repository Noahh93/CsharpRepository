using Amazon.Example.Association.Agreggation;
using Amazon.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example
{


    public class City : ICity
    {

        private Country _country;
        private string cityName;
        private int cityID;

        public City(string Country, string _cityName, int _cityID)
        {
            cityName = _cityName; 
            cityID = _cityID;
            _country = new Country("Italia", "Milan");
        }
        public void CityInfo(int cityID, string cityName)
        {
            Console.WriteLine($"The city with this ID: {cityID} is called {cityName}");
        }
        public void DisplayCity()
        {
            Console.WriteLine($"{cityName} {cityID}");
        }
        public void SadCity()
        {

        }
        public void CountryCity()
        {
            _country.CountryCity("Africa", "Tanzania");
        }

    }
}
