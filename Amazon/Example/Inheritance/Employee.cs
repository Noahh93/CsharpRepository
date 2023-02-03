using Amazon.Example;
using System;

namespace Amazon.examples.Inheritance
{ 

    public class Employee
    {
        public virtual void EmployeeName(string FirstName, string LastName)
        {
            Console.WriteLine($"This employees name is :{FirstName}, {LastName}");
        }
    }
}