using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association
{
    internal class Bank
    {
        Customer _customer; 

        public Bank(Customer customer)
        {
            _customer = customer;
            Console.WriteLine("NordBank");
        }
    }
}
