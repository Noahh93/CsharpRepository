using System;

namespace Amazon.examples.Inheritance
{

    public class Cat : Animal
    {
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
