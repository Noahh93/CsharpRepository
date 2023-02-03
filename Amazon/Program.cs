
using Amazon.Example.Inheritance;
using Amazon.examples.Inheritance;


Vehicle vehicle = new Vehicle();
vehicle.Wheels();
vehicle.Windows(4);
vehicle.Engine();

int number1 = vehicle.Doors();
Console.WriteLine(number1);
string number2 = vehicle.Wipers(9);
Console.WriteLine(number2);

string VariableOne = vehicle.VehicleColor("Blue");
Console.WriteLine(VariableOne);

string VariableTwo = vehicle.VehicleName();
Console.WriteLine(VariableTwo);

Console.ReadKey();


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
2. Abstraction = Show necessity                                I/
3. Inheritance =  In inheriance the parent class constructor is 
                    called before the child class constructor    I/
4. Polymorphism =                                              I/
//--------------------------------------------------------------------*/