using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.GenericsExample
{
    internal class Database<T>
    {
        public T GenData { get; set; }
        private T _genField;

        public void GenMethod(T age, T name)
        {
            Console.WriteLine($"{age} and {name}");
        }
        
    }
}
