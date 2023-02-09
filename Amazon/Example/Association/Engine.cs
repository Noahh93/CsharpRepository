using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association
{
    internal class Engine
    {
        public void V8(int cylinderAmount, string engineType) 
        {
            Console.WriteLine($"This engine is of the type {engineType} and has {cylinderAmount} cylinders. ");
        }
    }
}
