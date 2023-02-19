using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association.Agreggation
{
    internal class Window : Door
    {
        Door _door;
        

        public Window(Door door) 
        {
            _door = door;
            Console.WriteLine("I am a Window");
        }

    }
}
