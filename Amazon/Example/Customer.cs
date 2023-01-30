using Amazon.Example;
using Amazon.examples.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Amazon.Ecommerce
{
    internal class Customer : Person    
    {
        public Customer()
        {
            Console.WriteLine("Customer Constructor");
        }
        public override void Sound()
        {
            Console.WriteLine("Sound");
        }
        public override void HumanSound(string SoundName)
        {
            Console.WriteLine($"Sound of human = {SoundName}");
        }
    }

    internal class Employee
    {
        public void GetEmployeeCompanyName() 
        {
            Animal animal = new Animal();  //Can be reached without inheritance
            animal.Voice();
            animal.Sleep();
            Console.WriteLine("Amazon");
        }
        
    }

}
