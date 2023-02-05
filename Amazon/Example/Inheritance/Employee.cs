using Amazon.Example;
using System;
using System.ComponentModel.DataAnnotations;

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

        private int _age;
        private string _name;
        public Employee(Employee employee)
        {
            this._age = employee._age;
            this._name = employee._name;
        }
        public Employee(int age, string name)
        {
            _age = age;
            _name = name;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee age = {_age} employee name = {_name}");
        }
        public Employee()
        {

        }
        public void DisplayEmployeeAccount(Account account)
        {
            Console.WriteLine($"This account ID = {account.DisplayAccount()}");
        }
    }
}