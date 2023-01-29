using System;

namespace Amazon.examples.Inheritance
{

    public class Lion : Animal
    {
        public Lion() 
        {
            //this._id = 5555554;
            Console.WriteLine("ChildClass Constructor Lion");
        }

        public Lion(int id, int age, string name, string country) : base(id, age, name, country)
        {
            Console.WriteLine("Parameterized constructor");
        }

        public void DisplayLionDetail()
        {
            Console.WriteLine($"The lion ID is {this._id}, the lion age is {this._age}, and the name is {this._name}");
        }

        public void Attack()
        {
            this.Food();
            Console.WriteLine(this._id);                                                            
                                                                                                    // Class can access their own private, public and protected members
                                                                                                    // ChildClass can access only protected and public members of the ParentClass
                                                                                                    // use "this." keyword in the childClass to access the protected and public of the Parentclass
                                                                                                    // 
            Console.WriteLine($"The lion attack with {this.Eyes} eyes and with legs {this.Legs}");  //this. means object of a class
        }
        private void Food()
        {
            Console.WriteLine("The lion doesn't share this food outside the class");
        }
        public override void Color()
        {
            Console.WriteLine("Yellow");
        }
        public override string Race(string RaceName)
        {
            string name = ($"Lion Race = {RaceName}");
            return name;
        }
         /*
         Method Overriding:
         Child class method has
            Same name
            Same parameter
            Same return type string/int
        parentclass - virtual
        childclass - override
         */
    }

}

