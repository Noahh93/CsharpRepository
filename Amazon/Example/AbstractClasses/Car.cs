using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.AbstractClasses
{
    internal class Car : Vehicle
    {
        public override string VehicleInfo()
        {
            return "I am a Car class method";
        }
    }
}
