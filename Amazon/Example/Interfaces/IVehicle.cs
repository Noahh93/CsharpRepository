using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Interfaces
{
    public interface IVehicle
    {
        int Model { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        string Wipers(int totalWipers);
        int Doors();
        void Wheels();
        void Engine();

        void Windows(int totalWindows);


    }
}
