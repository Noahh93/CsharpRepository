using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.Inheritance
{   
    internal abstract class Doctor
    {
        public abstract void Specialization();  //HAVE TO OVERRIDE IN CHILDCLASS
        public virtual string DoctorDress()     //CAN OVERRIDE IN CHILDCLASS
        {
            return "Doctor Coat is white";
        }
        public string Age(int age)
        {
            return $"Doctor age is {age}";
        }
    }
}
