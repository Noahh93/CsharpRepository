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

        public void Sittt()
        {
            Console.WriteLine("Person Sit");
        }
        public Person()
        {
            Console.WriteLine("Person Construcor");
        }
        public abstract void Sound();   //2. Abstract class never have implementation or body,
                                        //3. Can only be reached in override
        public abstract void HumanSound(string SoundName);
    }
}
