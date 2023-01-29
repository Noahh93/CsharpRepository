using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Inheritance
{
    internal class EmployeeChildClass : EmployeeRecruiter
    {
        public override string BasicSalary(string salary)
        {
            string Newsalary = ($"New salary is {salary}");
            return Newsalary;
        }
    }
}
