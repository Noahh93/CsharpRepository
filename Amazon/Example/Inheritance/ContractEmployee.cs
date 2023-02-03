using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Inheritance
{
    internal class ContractEmployee : FullTimeEmployee
    {
        public override void EmployeeName(string FirstName, string LastName)
        {
            Console.WriteLine($"{FirstName}, {LastName} - ContractEmployee");
        }



    }
}
