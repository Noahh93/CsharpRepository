using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Interfaces
{
    public interface ICity
    {

        public void CityInfo(int cityID, string cityName);

        public void DisplayCity();
    }
}
