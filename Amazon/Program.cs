
using Amazon.Example.Inheritance;
using Amazon.Example.Interfaces;
using Amazon.examples.Inheritance;

//Association, Compisiton and Agregation


// POLYMORPHISM has Static/CompileTime      and     Dynamic/Runtime Polymorphism        (operator overloading later)

//Static/CompileTime = same name and same type gives error or "method overloading".
Employee employee = new Employee();
string example1 = employee.EmployeeSalary(4.5);
Console.WriteLine(example1);

int example2 = employee.EmployeeSalary(55);
Console.WriteLine(example2);

//Dynamic/Runtime = Method overriding or Overriding

Employee fullTimeEmployee = new FullTimeEmployee();         //BaseClass creating a refence in the InheritedClass
fullTimeEmployee.EmployeeName(" Mansour", "Mujahed ");
fullTimeEmployee.EmployeeCompanyName();
fullTimeEmployee.FullTimeEmployeeMethod();                  

Employee partTimeEmployee = new PartTimeEmployee();
partTimeEmployee.EmployeeName(" Jared", "Johnson ");

IVehicle vehicle = new Vehicle();
//vehicle.VehicleName();
vehicle.Doors();

Doctor heartSurgeon = new HeartSurgeon();                   //BaseClass creating a refence in the InheritedClass
//heartSurgeon.Car();
heartSurgeon.Specialization();
heartSurgeon.DoctorDress();
heartSurgeon.Age(45);
                                                            //ASSIGNMENT: practice inheritances. Abstract and interfaces, everything about it.


string drink1 = "Pepsi";                                           //ASSIGNMENT: Swap the values between the variables.
string drink2 = "Water";
string temp =   "";

temp = drink1;
drink1 = drink2;
drink2 = temp;

//temp becomes drink1
//drink1 becomes drink2
//drink2 becomes temp(drink1)

//||\\
Console.WriteLine($"{drink1}");
Console.WriteLine($"{drink2}");










Console.ReadKey();


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