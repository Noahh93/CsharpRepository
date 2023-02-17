using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.AbstractClasses
{
    internal abstract class GrandMother
    {
        string _toWho;

        public GrandMother(string toWho) 
        {
            _toWho = toWho;
        }
        public virtual void Greetings()
        {
            Console.WriteLine("my name is GrandMother and this greeting is to" + _toWho);
        }

    }
}
