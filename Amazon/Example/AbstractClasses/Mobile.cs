using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Example.AbstractClasses
{
    internal abstract class Mobile
    {
        private int _id;
        private string _name;

        public Mobile(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public virtual string GetMobileInfo()
        {
            return $"This mobile {_name} has the ID: {_id}";
        }
    }
}
