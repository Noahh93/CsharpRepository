using System;

namespace Amazon.examples.Inheritance
{

    public class Animal
    {
        public int Legs { get; set; }  //Properties (Initially public)
        public int Eyes { get; set; }

        protected int _id;               //Fields (Initially private)
        protected int _age;
        protected string _name;
        protected string _country;

        public Animal(int id, int age, string name)
        {
            _id = id;
            _age = age;
            _name = name;
        }
        public Animal(int id, int age, string name, string country)  //THIS IS TOMORROWS ASSIGNMENT, fill out this info on Program.cs
        {
            _id = id;
            _age = age;
            _name = name;
            _country = country;
        }

        public Animal(string name)
        {
            _name = name;
        }
        public Animal()
        {
            Console.WriteLine("Parent ConstructorClass Animal");
        }

        public void Sit()
        {
            Console.WriteLine("Sit");
        }
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
        public void Run()
        {
            Console.WriteLine("Run");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
        public void Jump()
        {
            Console.WriteLine("Jump");
        }
        public void Voice()
        {
            Console.WriteLine("Animal Voice");
        }
        public virtual void Color()
        {
            Console.WriteLine("Black");
        }

                                                                        /*
                                                                 Method Overriding:
                                                                 Child class method has
                                                                    Same name
                                                                    Same parameter
                                                                    Same return type string/int
                                                                parentclass - virtual
                                                                childclass - override (or "abstract" if it's an abstract class)
                                                                 */
        public virtual string Race(string RaceName)         
        {
            string name = ($"ParentClass {RaceName}");
            return name;
        }

    }
}
