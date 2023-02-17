using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.AbstractClasses
{

    internal class Mother : GrandMother
    {

        public Mother (string toWhatPerson) : base(toWhatPerson)
        {

        }
        //public override void Greetings()
        //{
        //   Console.WriteLine("Greetings from GrandMother to Mother");
        //}




    }
    
}
