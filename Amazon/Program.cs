
using Amazon.Example;
using Amazon.Example.Association;
using Amazon.Example.Association.Agreggation;
using Amazon.Example.Inheritance;
using Amazon.Example.Interfaces;
using Amazon.examples.Inheritance;
using System.ComponentModel.DataAnnotations.Schema;

//__________________________________________________________________________________________________________________________\\
//CREATE AN INFERFACE OF "CITY". WITH 2 METHODS.
//FIRST METHOD(CITY ID, CITYNAME)
//SECOND METHOD = "DISPLAYCITY"
//CREATE 1 CLASS "CITY" AND INHERITE "CITY" FROM INTERFACE
//IN THE CITY CLASS INITIALIZE 2 FIELDS. CITYID AND CITYNAME
//IN THE PROGRAM.CS DISPLAY CITY AND CALL "SADCITY" METHOD
//DISPLAY CITY AGAIN
//CREATE RELATIONSHIP BETWEEN COUNTRY AND CITY

//country - city - student - ICity
City city = new City("Mongolia","Dubai", 1234);
city.SadCity();
city.CityInfo(124, "LasVegas");
city.DisplayCity();
city.CountryCity();

Country country = new Country("Spain", "Madrid");
//country.DisplayCity();


Student student = new Student("Noah", 23424);
student.StudentInfo();
student.StudentVisitor();


//--------------------------------------------------------------------------------------------------------------------------\\








//__________________________________________________________________________________________________________________________\\
//Inheritance = Relationship "IS a"              Association = Relationship "HAS a"
//Association is a relationship between 2 different classes that are established through their objects (many-many) (1-many) (many-1) all are association
//Association =  1.Composition 2.Aggregation  << 

//CREATE A RELATION BETWEEN STUDENT AND COUNTRY
//Display studentName, studentCountry, and studentID


//--------------------------------------------------------------------------------------------------------------------------\\














//Association, Compisiton and Agregation


// POLYMORPHISM has Static/CompileTime      and     Dynamic/Runtime Polymorphism        (operator overloading later)

//Static/CompileTime = same name and same type gives error or "method overloading".
//Employee employee = new Employee();
//string example1 = employee.EmployeeSalary(4.5);
//Console.WriteLine(example1);

//int example2 = employee.EmployeeSalary(55);
//Console.WriteLine(example2);

//Dynamic/Runtime = Method Overriding

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