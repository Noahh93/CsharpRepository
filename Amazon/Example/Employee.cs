using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example
{
    class EmployeeRecruiter
    {
        public virtual string BasicSalary(string salary)
        {
            Console.WriteLine("Salary 1000");
            return salary;
        }
    }
    internal class Employee
    {
        //Fields (always initially private)
        private int _id;
        private string _name;
        private int _age;
        private int _salary;
        private readonly string _adress = "Washington"; 
        // On line 18, you can ONLY change the value in a constructor in the same class and not in a method
        
        //Property (always initially public, always set name with Capital letter)

        public string City { set; get; }
        public int Salary 
        {
            set { _salary = value; }
            get { return _salary; }
        }

        public string Country { get; private set; }

        public Employee()
        {
            _adress = "Washington123";
            Country = "Sweden";
            _salary = 24000;
        }

        

        public int Age
        {
            set
            {
                if (value < 19)
                {
                    Console.WriteLine("Age is less than 19");
                }
                else
                {
                    _age = value;
                }

            }                                                                                           //{  set; get; }
            get 
            {

                Console.WriteLine("Salam Aleykom");
                return _age;
                Console.WriteLine("Wa Aleykom Salam");
            }

        }

        public string Name
        {
            set;
            get; 
        }

        public int Id 
        { 
            
            set { _id = value; }
            get { return _id; }
        }
        

        
        public Employee(int id, string name, int age)       //Constructor
        {
            _id = id;
            _name = name;
            _age = age;
        }
        public Employee(Employee employee)
        {
            _name = employee._name;
            _age = employee._age;
        }
        //public Employee() 
        //{
        //    _id = -1;
        //    _name = "No name";
        //    Console.WriteLine("Constructor");
        //}
        public Employee(int ID, string NAME)
        {
            _id = ID;
            _name = NAME;
            Console.WriteLine("Parametarized constructor");
        }


        //public void setAdress(string adress)
        //{
        //    _adress = adress;

        //}
        public string getAdress()
        {
            return _adress;
        }
/*
        //Methods
        public string GetEmployeeName()
        {
            return _name;
            Console.WriteLine("ADAODAWdOL");
        }
        public void SetEmployeeName (string name)
        {
            _name = name;
            

        }
        public int GetAge()
        {
            return _age;

        }
        public void SetAge(int value)
        {
            _age = value;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine("WOW!");
        }
        public void SetEmployeeId(int id)
        {
            _id = id;
        }
        public int GetEmployeeId()
        {
            return _id;
        }

        public int EmployeeSalary(int N1, int N2)
        {
            string name = "Jonny";
            int SUM = N1 + N2;
            return SUM;
        }
        public void EmployeeBioData(int ID, string Name)
        {
            Console.WriteLine(ID);
            Console.WriteLine(Name);
        }

*/
    }

    


}
