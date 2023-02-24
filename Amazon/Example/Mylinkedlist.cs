using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example
{
    internal class Mylinkedlist
    {

        public bool Find(int number, Node data)
        {
            while (data != null)
            {
                
                if (data.data == number)
                {
                    return true;
                }
                data = data.next;
            }

            return false;
        }






















        //public bool Search(int data, Node header)
        //{
        //    while (header != null)
        //    {
        //        if (header.data == data)
        //        {
        //            return true;
        //        }
        //        header = header.next;
        //    }

        //    return false;
        //}
    }
}
