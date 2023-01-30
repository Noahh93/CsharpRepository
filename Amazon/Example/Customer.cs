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
        

        public Customer() : base (234, "Jonny")
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
        public override int HumanAge()
        {
            return 45;
        }
        public override void HumanTeeth()
        {
            Console.WriteLine("Customer has 25 teeth");
        }

    }

    internal class Employee : Person
    {
        public void GetEmployeeCompanyName() 
        {
            Animal animal = new Animal();  //Can be reached without inheritance
            animal.Voice();
            animal.Sleep();
            Console.WriteLine("Amazon");
        }
        public override void Sound()
        {
            Console.WriteLine("Sound of an EmpoyeEeeEe");
        }
        public override void HumanSound(string SoundName)
        {
            Console.WriteLine($"Sound of an Human {SoundName}");
        }
        public override int HumanAge()
        {
            Console.WriteLine();
            return 105;
        }
    }

}
