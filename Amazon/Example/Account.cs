using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example
{
    public class Account
    {
        private int _id;
        public Account(int id) 
        {
            _id = id;
        }
        public int DisplayAccount()
        {
            return _id;
        }
    }
}
