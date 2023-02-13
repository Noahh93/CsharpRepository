using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example
{
    internal class ChildMyMeth : MyMeth
    {

        public override bool IsNumberEven(int number)
        {

            int result = number % 2;
             
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
