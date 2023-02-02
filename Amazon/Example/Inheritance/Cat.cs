using System;

namespace Amazon.examples.Inheritance
{

    public class Cat : Animal
    {
        protected string _state;
        public Cat(int id, int age, string name, string country, string state) : base(id, age, name, country) 
        {
            _state = state;
        }

        public Cat(string name) : base(name) 
        {

        }

        public Cat() 
        {
            Console.WriteLine("ChildClass Constructor Cat");
            Console.WriteLine(this.Eyes);
        }
        public override void Color() 
        {
            Console.WriteLine("White");
        }
        public void Dance()
        {
            Console.WriteLine("Cat dance");
        }

    }
}
