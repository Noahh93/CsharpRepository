using Amazon.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Inheritance
{
    internal class Vehicle : IVehicle, IVehicleDetail       //Multiple inheritance is only allowed through interfaces
    {
        public string VehicleName()
        {
            return "Name of this car is Toyota";
        }
        public int Model { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public void Wheels()
        {
            Console.WriteLine("The car has 4 Wheels in total");
        }
        public void Engine()
        {
            Console.WriteLine("V8 Engine");
        }
        public void Windows(int totalWindows)
        {
            Console.WriteLine($"The car has {totalWindows} in total");
        }
        public int Doors()
        {
            return 5;
        }
        public string Wipers(int totalWipers)
        {

            return $"Total number of wipers is {totalWipers} ";
            
        }
        public string VehicleColor(string color)
        {

            return $"The color of this car is {color}";
        }
    }
}
