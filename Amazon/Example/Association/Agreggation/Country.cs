using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association.Agreggation
{
    internal class Country
    {
        private string _countryName;
        string _cityName;

        public Country(string countryName, string cityName)
        {
            _countryName = countryName;
            _cityName = cityName;
        }
        public void CountryStudent()
        {
            Console.WriteLine(_countryName);
        }
        public void CountryCity(string countryName, string cityName) 
        { 
            Console.WriteLine($"This country '{_countryName}' has a city by the name of {_cityName}"); 
        }


    }

}
