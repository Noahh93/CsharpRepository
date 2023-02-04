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
        public void EmployeeCompanyName()
        {
            Console.WriteLine("Amazon");
        }
        public string EmployeeCompanyName(string name)
        {
            return "Microsoft";
        }
        public int EmployeeSalary(int amount)
        {
            return 25000;
        }
        public string EmployeeSalary(double number)
        {
            return "EmployeeSalary is 10.000";
        }
        public virtual void FullTimeEmployeeMethod()
        {
            Console.WriteLine("Parent Fulltime Employee Method");
        }
    }
}