using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Association.Agreggation
{
    internal class Courses
    {
        private string _courseName;
        private int _courseID;
        

        public Courses(string courseName, int courseID) 
        {
            _courseName = courseName;
            _courseID = courseID;
        }
        public void ParticularCourse()
        {
            Console.Clear();
            Console.WriteLine("Choose the course you want to study: Chemistry or History? ");
            string className = Console.ReadLine();
            className.ToUpper();

            if (className == "CHEMISTRY")
            {
                
            }
            else if (className == "HISTORY")
            {
                
            }
        }
        public void DisplayCourse()
        {

            Console.WriteLine($"Course ID = {_courseID} and course name = {_courseName}");
        }
    }
}
