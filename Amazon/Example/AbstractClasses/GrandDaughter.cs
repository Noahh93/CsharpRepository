using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.AbstractClasses
{
    internal class GrandDaughter : Daughter
    {
        public GrandDaughter(string whatIndividual) : base(whatIndividual)
        {

        }
        //public override void Greetings()
        //{
        //    Console.WriteLine("Greetings from Daughter to GrandDaughter");
        //}
    }
}
