
using Amazon.Example;
using Amazon.Example.Association;
using Amazon.Example.Inheritance;
using Amazon.Example.Interfaces;
using Amazon.examples.Inheritance;
using System.ComponentModel.DataAnnotations.Schema;

//Inheritance = Relationship "IS a"              Association = Relationship "HAS a"

//Association is a relationship between 2 different classes that are established through their objects (many-many) (1-many) (many-1) all are association
//
//Association =  1.Composition 2.Aggregation  << 

        Amazon.examples.Inheritance.Employee employee1 = new Amazon.examples.Inheritance.Employee(40, "Abdu");
        employee1.DisplayEmployee();
        Account accountemployee1 = new Account(54);
        employee1.DisplayEmployeeAccount(accountemployee1);

        Amazon.examples.Inheritance.Employee employee2 = new Amazon.examples.Inheritance.Employee(30, "Rakesh");
        employee2.DisplayEmployee();
        Account accountemployee2 = new Account(405);
        employee2.DisplayEmployeeAccount(accountemployee2);

        Amazon.examples.Inheritance.Employee employee3 = new Amazon.examples.Inheritance.Employee(employee1);
        employee3.DisplayEmployee();


Amazon.Example.Association.Human human = new Amazon.Example.Association.Human();
human.HumanActivity();
human.HeartActivity();
human.HairActivity();




string name;
Brain brain2;

//Create a HairClass and right a few methods like the examples above "human.hair" shows "hair is black"

string[] Countries = new string[10];

Countries[0] = "Afghanistan";
Countries[1] = "Hindustan";
Countries[5] = "Dubai";
Countries[9] = "Sri Lanka";

//Arrey = datastructure
int[] num = new int[5];
num[0] = 15;
//num[1] = 20;
//num[2] = 30;
num[3] = 35;
num[4] = 40;

int length = num.Length;

                                            //Next ASSIGNMENT. DISPLAY SUM OF ALL VALUES

for (int i = num.Length -1; i >= 0; i--)
{
    Console.WriteLine(num[i]);
}

Console.ReadKey();











//Association, Compisiton and Agregation


// POLYMORPHISM has Static/CompileTime      and     Dynamic/Runtime Polymorphism        (operator overloading later)

//Static/CompileTime = same name and same type gives error or "method overloading".
//Employee employee = new Employee();
//string example1 = employee.EmployeeSalary(4.5);
//Console.WriteLine(example1);

//int example2 = employee.EmployeeSalary(55);
//Console.WriteLine(example2);

//Dynamic/Runtime = Method overriding or Overriding

//Employee fullTimeEmployee = new FullTimeEmployee();         //BaseClass creating a refence in the InheritedClass
//fullTimeEmployee.EmployeeName(" Mansour", "Mujahed ");
//fullTimeEmployee.EmployeeCompanyName();
//fullTimeEmployee.FullTimeEmployeeMethod();                  

//Employee partTimeEmployee = new PartTimeEmployee();
//partTimeEmployee.EmployeeName(" Jared", "Johnson ");

//IVehicle vehicle = new Vehicle();
//vehicle.VehicleName();
//vehicle.Doors();

//Doctor heartSurgeon = new HeartSurgeon();                   //BaseClass creating a refence in the InheritedClass
//heartSurgeon.Car();
//heartSurgeon.Specialization();
//heartSurgeon.DoctorDress();
//heartSurgeon.Age(45);
//ASSIGNMENT: practice inheritances. Abstract and interfaces, everything about it.


//int a = 30;
//int b = 50;

//Game game = new Game();
//game.Swap(ref a, ref b);

//||\\
//Console.WriteLine($"a = {a}");
//Console.WriteLine($"b = {b}");

//Fish fish = new Fish();
//fish.Name = "Julia";
//game.GameIsDancing(new Fish());
//Console.WriteLine(fish.Name);
//Console.WriteLine(fish.Age);




//   STACK       HEAP    //FROM STACK >> POINTING TOWARDS A HEAP
//Fish fish1 = new Fish(); //ADRESS X451 on a HEAP
//fish1.Name = "Julia";

//Fish fish2 = fish1;     //ADRESS X451 on a HEAP
//fish2.Name = "Barbara";

//Console.WriteLine($"fish1 name = {fish1.Name}"); // "Barbara"
//Console.WriteLine($"fish2 name = {fish2.Name}"); // "Barbara "

//Amazon.Example.Table table1 = new Amazon.Example.Table();

//Fish fish3 = new Fish(); //ADRESS X81






/*
Vehicle vehicle = new Vehicle();
vehicle.Wheels();
vehicle.Windows(4);
vehicle.Engine();
                                              >>  INTERFACES here  <<
int number1 = vehicle.Doors();
Console.WriteLine(number1);
string number2 = vehicle.Wipers(9);
Console.WriteLine(number2);

string VariableOne = vehicle.VehicleColor("Blue");
Console.WriteLine(VariableOne);
                                    
string VariableTwo = vehicle.VehicleName();
Console.WriteLine(VariableTwo);
*/




/* 
 We Checked: 

sealed
interface
constructors "base" keyword
 */
















//FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
//fullTimeEmployee.EmployeeName("Noah","Amin");


//PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
//partTimeEmployee.EmployeeName("Salman","Khan");


//ContractEmployee contractEmployee = new ContractEmployee();
//contractEmployee.EmployeeName("Shahrukh", "Khan");













//       ***    HIGH IMPORTANCE LEVEL      ***

// 1. Single inheritance = ParentClass only has one ChildClass
// 2. HierarchalClass = If one single parent class has several child classes
// 3. Multilevel inheritance GrandFather > Father > Son (chain)
// C# Doesn't support multiple inheritance, it uses interfaces instead.

// Inheritance can be indentified by the "IS - A" words (is a relationship)



/*//____________________________________________________________________
OOP (Object-Oriented-Programming) has 4 principles/Rules.      I/

1. Encapsulation = Hiding complexity behind functionalities    I/
2. Abstraction = has abstract methods                                I/
3. Inheritance =  In inheriance the parent class constructor is 
                    called before the child class constructor    I/
4. Polymorphism = static/dynamic change                                            I/
//--------------------------------------------------------------------*/