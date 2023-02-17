using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.AbstractClasses
{
    internal abstract class Animal
    {
        
        public Animal() 
        {
            Console.WriteLine("This is AnimalClass");
        }
        public string GrandSon(string name)
        {
            string detail = $"My grandsons name is {name}";
            return detail;
        }
    }
}
