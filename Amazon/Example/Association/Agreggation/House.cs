using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association.Agreggation
{
    internal class House
    {
        Window _window;

        public House(Window window)
        {
            _window = window;
            Console.WriteLine("Im a House");
        }
    }
}
