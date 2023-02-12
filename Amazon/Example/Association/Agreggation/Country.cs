using Amazon.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association.Agreggation
{
    internal class Country : ICountry
    {

        City[] _cities;

        public Country()
        {
            _cities = new City[3];
            _cities[0] = new City("New York", 123);
            _cities[1] = new City("Paris", 123);
            _cities[2] = new City("Amsterdam", 123);
        }
        public void DisplayCities()
        {
            _cities[0].DisplayCity1();
            _cities[1].DisplayCity1();
            _cities[2].DisplayCity1();

        }
        
    }

}
