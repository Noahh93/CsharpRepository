using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association
{
    internal class Wheels
    {
        public void Tires(int amount)
        {
            Console.WriteLine($"There are {amount} tires connected");
        }
        public void MovingTires()
        {
            Console.WriteLine("Tires are moving");
        }
    }
}
