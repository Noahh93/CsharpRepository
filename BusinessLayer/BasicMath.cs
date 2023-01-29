using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BasicMath //Classes are Internal by default
    {
        public int Add(int x, int y)   //Class members are by default private
        {
            int SUM1 = x + y;
            return SUM1;
        }
        public int Multiply(int k, int l)
        {
            int SUM2 = k * l;
            return SUM2;
        }
    }
}
