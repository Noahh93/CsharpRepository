using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Inheritance
{
    internal class PartTimeEmployee : Amazon.examples.Inheritance.Employee
    {
        public override void EmployeeName(string FirstName, string LastName)
        {
            Console.WriteLine($"This employees name is :{FirstName}, {LastName} Partime");
        }



    }
}
