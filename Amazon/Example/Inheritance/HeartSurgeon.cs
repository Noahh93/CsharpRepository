using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Inheritance
{
    internal class HeartSurgeon : Doctor
    {
        public override void Specialization()
        {
            Console.WriteLine("HeartSurgeon Method");
        }
        public string Car()
        {
            return "Heart Surgeon has a red car";
        }
        
    }
}
