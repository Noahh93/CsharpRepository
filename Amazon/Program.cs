
using Amazon.Example;
using Amazon.Example.Inheritance;
using Amazon.examples.Inheritance;
using System.Data.Common;
using System.Runtime.CompilerServices;
using BusinessLayer;
using Amazon.Ecommerce;

BasicMath basicMath = new BasicMath();
int plus = basicMath.Add(3, 3);
Console.WriteLine(plus);

int multiply = basicMath.Multiply(4, 4);
Console.WriteLine(multiply);


Lion lion = new Lion (2432, 2, "Rambo", "Iraq");            // <<<< OBJECT, INSTANCE OF A CLASS
Elephant elephant = new Elephant(); // <<<< OBJECT, INSTANCE OF A CLASS

lion.Eyes = 2;          //Setting Property
lion.Legs = 4;          //Setting Property
lion.Attack();
lion.Color();
elephant.Color();

Animal animal = new Animal();
animal.Voice();


Cat cat = new Cat();
cat.Voice();
cat.Dance();

//Person person = new Person();         //This is an object of an abstract class which can't be created unless in the childClass
//person.Sittt();

Customer customer = new Customer();
customer.Sittt();
customer.HumanSound("Spanish Language");
customer.Sound();
int Age = customer.HumanAge();
Console.WriteLine($"Human age is: {Age}");
customer.HumanTeeth(); //Customer has 25 teeth


Amazon.Ecommerce.Employee employee = new Amazon.Ecommerce.Employee();
employee.Sound();
employee.HumanSound("Moshkeel");
int age = employee.HumanAge();
Console.WriteLine($"This persons age is: {age}");
employee.HumanTeeth(); //32


//this.Attack();  << Error, only use "this." in a ChildClass



string RaceName = lion.Race("Jungle");
Console.WriteLine(RaceName);
Console.ReadKey();
/*                                              INHERITANCE * INHERITANCE * INHERITANCE
Cat cat = new Cat();
cat.Color();
cat.Race("Home");                                                     //Override Parentclass method
Console.WriteLine(cat.Race("Grey"));

lion.DisplayLionDetail();


EmployeeChildClass employeeChildClass = new EmployeeChildClass();     //1. First create an object to be able to print out the ChildClass
string ShowSalary = employeeChildClass.BasicSalary("5000");           //2. Put it in a variable to use the Override Parentclass method
Console.WriteLine(ShowSalary);                                        //3. And then display it

//Console.WriteLine($"The lion is {lion._Age} years old");            //Getting Property
//Console.WriteLine($"The lion has {lion.Eyes} eyes");                //Getting Property
//Console.WriteLine($"The lion has this many legs: {lion.Legs}");     //Getting Property


lion.Sit();             //Calling Method through inheritance
lion.Run();             //Calling Method through inheritance

elephant.Eyes = 2;      //Setting Property
elephant.Legs = 4;      //Setting Property

elephant.Run();         //Calling Method
elephant.Sit();         //Calling Method
cat.Jump();
cat.Jump();

Console.WriteLine($"This elephant has {elephant.Eyes} eyes");  //Getting Property
Console.WriteLine($"The cat is jumping ");

Console.WriteLine(lion);
*/



/*















  Employee employee1 = new Employee();
employee1.Age = 18;

Console.WriteLine(employee1.Age);

employee1.Age = 10;

int employeeAge = employee1.Age;  

Console.WriteLine(employeeAge);

employee1.Id = 1;

employee1.Name = "Noah";
Console.WriteLine(employee1.Name);

employee1.City = "Stockolm";
Console.WriteLine(employee1.City);
employee1.Salary = 5200;
Console.WriteLine(employee1.Salary);
Console.WriteLine(employee1.Country);
//employee1.Country = "Germany";

//employee1.setAdress("Adress Washington");
Console.WriteLine(employee1.getAdress());

//Console.WriteLine(employee1.Id);



 * Non parametarized constructor
 * Parameterized constructor
 * Copy constructor
 * Private Constructor
 
 
Employee employee2 = new Employee();                //Object

Employee employee3 = new Employee(1983, "Abdullah");

Employee employee5 = new Employee(employee3);

string employeeName = employee3.GetEmployeeName();
Console.WriteLine(employee3.Name);


                                                                                                        On the RAM we have two types 
                                                       //Constructors                                      of memory HEAP and STACK
                                                                                                        All objects are created on HEAP. 

Constructor is a special method which has the same name as a class
Constructors have no return type
We need constructors to set default value of fields
If we dont write the constructor, the program creates a default constructor which we can't see and it sets the default value


                                        //____________________________________________________________________
                                        //OOP (Object-Oriented-Programming) has 4 principles/Rules.      I/
                                        
                                        //1. Encapsulation = Hiding complexity behind functionalities    I/
                                        //2. Abstraction = Show necessity                                I/
                                        //3. Inheritance =  In inheriance the parent class constructor is 
                                                            called before the child class constructor    I/
                                        //4. Polymorphism =                                              I/
                                        //--------------------------------------------------------------------


                                                       //Methods in-depth

Method over-loading ( several methods with the same name and different parameters )


Employee employee1 = new Employee();
employee1.SetEmployeeName("Noah");
employee1.SetEmployeeId(11);
string emp = employee1.GetEmployeeName();
Console.WriteLine(emp);

Employee employee2 = new Employee();
employee2.SetEmployeeName("Waqas");
string emp2 = employee2.GetEmployeeName();
Console.WriteLine(emp2);

Employee employee3 = new Employee();
employee3.SetEmployeeName("Ali");
employee3.SetEmployeeId(43);
string emp3 = employee3.GetEmployeeName();
Console.WriteLine(emp3);
int employeeId1 = employee1.GetEmployeeId();
Console.WriteLine(employeeId1);

int employeeId2 = employee2.GetEmployeeId();
Console.WriteLine(employeeId2);

int employeeId3 = employee3.GetEmployeeId();
Console.WriteLine(employeeId3);

                                        

Employee employee1 = new Employee();
employee1.id = 1;
employee1.name = "Jonny";

Employee employee2 = new Employee();
employee2.id = 2;
employee2.name = "Alarto";

Console.WriteLine(employee1.id);   //1
Console.WriteLine(employee1.name); //Jonny

Console.WriteLine(employee2.id);  //2
Console.WriteLine(employee2.name);//Alarto





Amazon.Ecommerce.Employee employee1 = new Amazon.Ecommerce.Employee();
employee1.GetEmployeeCompanyName();

Amazon.Ecommerce.Employee employee2 = new Amazon.Ecommerce.Employee();
employee2.GetEmployeeCompanyName();


Employee employee = new Employee();
string employeeName = employee.GetEmployeeName();
Console.WriteLine(employeeName);

int salary = employee.EmployeeSalary(10, 20);
Console.WriteLine(salary);

string name = "Jonny";
int id = 50;
employee.EmployeeBioData(id, name);
*/

