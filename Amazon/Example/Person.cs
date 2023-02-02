using Amazon.examples.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example
{
    internal abstract class Person          //Can only be reached through inheritance because it's abstract
                                            //1. can't create OBJECTS of this class
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
        public int ID { get; set; }

        protected string _country;

        public Person()         //Constructors dont have VOID
        {
            Console.WriteLine("Person Constructor");
        }
        public Person(int age)
        {

        }
        public Person(string country)
        {
            _country = country;
        }
        public Person(int num, string name)
        {

        }
        public Person(string A, string B, string C, string D, string E)
        {

        }

    //Constructors above
    // Methods below this line

        public void StandStill()
        {
            Console.WriteLine("StandStill from abstract class Person");
        }
        public void Sittt()
        {
            Console.WriteLine("Person Sit");
        }

        public abstract void StandStill2();
        public abstract void Sound();   //2. Abstract class never have implementation or body,
                                        // Can only be reached in override
        public abstract void HumanSound(string SoundName);
        public abstract int HumanAge();  //3.You have to override
        public virtual void HumanTeeth() //You can override
        {
            Console.WriteLine("Human has 32 teeth");
        }
    }
}
