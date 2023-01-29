using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example
{
    internal class Calculator
    {
        public int Add(int N1,int N2)
        {
            int SUM = N1 + N2;
            return SUM;
        }
        public int Add(int N1, int N2, int N3)
        {
            int SUM = N1 + N2 + N3;
            return SUM;
        }
        public int Add(int N1, int N2, int N3, int N4)
        {
            int SUM = N1 + N2 + N3 + N4;
            return SUM;
        }
        public int Add(int N1)
        {
            return N1;
        }

        public int Add()
        {
            return 50;
        }
    }
}
