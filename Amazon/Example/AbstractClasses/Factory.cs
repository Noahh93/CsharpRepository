using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.AbstractClasses
{
    internal class Factory
    {
        
        
        public Car GetCarVehicle()
        {
            
            Car carObject = new Car();
            return carObject;
        }
        public Truck GetTruckVehicle()
        {
            Truck truckObject = new Truck();
            return truckObject;
        }
        public string GetVehicle(string vehicle)
        {
            if (vehicle == "truck1")
            {
                return "I AM A TRUCK";
            }
            else if (vehicle == "car1")
            {
                return "I AM A CAR";
            }
            else
            {
                return "I AM A RICKSHAW";   
            }
        }
        public Vehicle GetVehicleObject(string nameVehicle)
        {
            if (nameVehicle == "truck")
            {
                Truck truck = new Truck();
                return truck;
            }
            else if (nameVehicle == "rickshaw")
            {
                Rickshaw rickshaw = new Rickshaw();
                return rickshaw;
            }
            else
            {
                Car car = new Car();
                return car;
            }
        }
    }
}
