using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Inheritance
{
    internal class FullTimeEmployee : Amazon.examples.Inheritance.Employee
    {
        //"sealed" keyword means that no childClass can inherite from that method
        //public override void EmployeeName(string FirstName, string LastName)  
        //{
        //    Console.WriteLine($"This employees name is :{FirstName}, {LastName} Fulltime");
        //}

        //public override void FullTimeEmployeeMethod()
        //{
        //    Console.WriteLine("Child Fulltime Employee Method");
        //}



    }

    
}
