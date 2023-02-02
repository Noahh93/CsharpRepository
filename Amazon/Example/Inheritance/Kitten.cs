using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.examples.Inheritance;

namespace Amazon.Example.Inheritance
{
    internal class Kitten : Cat
    {
        public Kitten(int id, int age, string name, string country, string state) : base(id, age, name, country, state)
        {
            
        }
        public Kitten(string name) : base(name) //This constructor inherits from Cat and Cat inherits from Animal
        {
            Console.WriteLine("WOHO0o0o0");
        }
        public void DisplayName()
        {

            Console.WriteLine($"This Kitten's name is{this._name}");
        }
        public void KittenName(string name)
        {
            Console.WriteLine(name);
        }
        public void DisplayDetail()
        {
            Console.WriteLine($"Kitten ID is = {this._id}, Age = {this._age}, Name = {this._name}, Country = {this._country}, Cat state = {this._state}");
        }
    }
}
