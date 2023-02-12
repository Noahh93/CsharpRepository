using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association.Agreggation
{
    internal class Student
    {
        private Country _country;
        private string _studentName;
        private int _studentID;

        public Student(string studentName, int studentID) 
        {
            //_country = new Country("Sweden", "Stockholm");
            _studentName = studentName;
            _studentID = studentID;
        }
        
        public void StudentVisitor()
        {

            //_country.CountryStudent();
        }
        public void StudentInfo()
        {
            Console.WriteLine($"student ID = {_studentID} student Name = {_studentName}.\n This student is from {_country}");
        }
    }
}
