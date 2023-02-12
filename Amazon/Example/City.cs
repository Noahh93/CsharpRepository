using Amazon.Example.Association.Agreggation;
using Amazon.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example
{


    public class City
    {
        private string cityName;
        private int cityID;

        public City(string _cityName, int _cityID)
        {
            cityName = _cityName; 
            cityID = _cityID;
        }
        public void DisplayCity1()
        {
            Console.WriteLine($"{cityName} and {cityID}");
        }


    }
}
