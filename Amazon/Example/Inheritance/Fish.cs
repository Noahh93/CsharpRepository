using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Inheritance
{
    internal class Fish
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public void Eat() 
        {
            Console.WriteLine("FishEast");
        }
    }
}
