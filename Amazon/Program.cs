//using Amazon.Example;
//using Amazon.Example.AbstractClasses;
//using Amazon.Example.Association;
//using Amazon.Example.Association.Agreggation;
using UserRegistration;
using UserRegistration.Services;


Service service = new Service();
service.Register(1, "Noah", "noah@hotmail.com", "123", "Sweden");
service.Register(2, "Johnny", "johnny@hotmail.com", "222", "Sweden");
service.Register(3, "BigBoy", "Big32@hotmail.com", "212", "USA");
service.Register(4, "Rambo", "Rambo_32@hotmail.com", "222", "Kazakhstan");
service.Register(5, "LittleBoy", "Small32@hotmail.com", "2162", "Sweden");
//service.DisplayUsers();
//service.ChangePassword("Rambo_32@hotmail.com", "Rambo12X");
//service.ChangePassword("Small32@hotmail.com", "LittleBoy");
//Console.WriteLine("***********************");
//service.DisplayUsers();
//service.DisplayTotalUsersByCountry("Sweden");
//service.Login("noah@hotmail.com", "123");
ProductService productService = new ProductService();
productService.RegisterProduct(1, "Head Phones", "Portable with good bass in red color", 45.99, DateTime.Now, 15);
productService.RegisterProduct(2, "Gloves", "Warm and fluffy made of wool", 13.49, DateTime.Now, 20);
productService.RegisterProduct(3, "Jeans", "Italian made from leather, water resistant", 119.99, DateTime.Now, 4);
productService.RegisterProduct(4, "Branded Jacket", "Very cool jacket, social status", 129.99, DateTime.Now, 16);
Console.WriteLine("*********************************  Before update  ************************************");

productService.DisplayProduct();
productService.UpdateProductByID(3, "Black Jeans", null, 55);
productService.UpdateProductByID(2, null, null, 100);
productService.UpdateProductByID(4, null, "Not cool, torn apart jacket", 0);
productService.UpdateProductByID(0, null, null, 0);
Console.WriteLine("*********************************  After update  ************************************");
productService.DisplayProduct();
//productService.DisplayProduct();
//productService.TotalProductsAvailable();
//service.PurchaseProduct("Jeans", 4);
//service.PurchaseProduct("Gloves", 4);
////service.DisplayUserOrder(4);
//service.PurchaseProduct("Head Phones", 1);
////service.DisplayUserOrder(1);
//service.PurchaseProduct("Branded Jacket", 5);
//service.PurchaseProduct("Gloves", 5);
//service.PurchaseProduct("Branded Jacket", 4);
//service.DisplayAllUserOrders();

//productService.DisplayHighestPriceProduct();

//Node node1 = new Node();
//node1.data = 1;


//Node node2 = new Node();
//node2.previous = node1;
//node2.data = 2;
//node1.next = node2;


//Node node3 = new Node();
//node3.data = 3;
//node3.previous = node2;
//node2.next = node3;


//Node node4 = new Node();
//node4.data = 4;
//node4.previous = node3;
//node3.next = node4;

//Node forwardHeader = node1;

//Mylinkedlist linkedList = new Mylinkedlist();
//bool istrue = linkedList.Find(3, forwardHeader);

//if (istrue == true)
//{
//    Console.WriteLine("Right number");
//}
//else
//{
//    Console.WriteLine("Wrong number");
//}









//            //Mylinkedlist linkedList = new Mylinkedlist();
//            //bool isNumberFound = linkedList.Search(20, forwardHeader);
//            //if (isNumberFound == true)
//            //{
//            //    Console.WriteLine($"Number exist in the list");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Number does not exist in the list");
//            //}

////while (forwardHeader != null)
////{
////    Console.WriteLine(forwardHeader.data);
////    forwardHeader = forwardHeader.next;
////}

////Console.WriteLine("\nReverse order\n");
////Node backwardheader = node4;

////while (backwardheader != null)
////{
////    Console.WriteLine(backwardheader.data);
////    backwardheader = backwardheader.previous;

////}

//Console.ReadKey();















////Node node1 = new Node();
////node1.data = 51;
////node1.next = null;

////Node node2 = new Node();
////node2.data = 61;
////node2.next = null;

////node1.next = node2;

////Node node3 = new Node();
////node3.data = 71;
////node3.next = null;

////node2.next = node3;

////Node node4 = new Node();
////node4.data = 81;
////node4.next = null;

////node3.next = node4;

////Node header = node1;

////while (header != null)
////{
////    Console.WriteLine(header.data);
////    header = header.next;
////}

////                                                       assignment
//// Data in order and in reverse order (NODES) through while loop.
//// 1.2.3.4.5 and then 5.4.3.2.1












////Recursive recursive = new Recursive();
////recursive.DisplayArray(arr, arr.Length);

////Recursive recursive = new Recursive();
////int sum = recursive.SumofRange(10);
////Console.WriteLine(sum);



////Node node1 = new Node();
////node1.data = 55;
////node1.next = null;

////Node node2 = new Node();
////node2.data = 65;
////node2.next = null;
////    node1.next = node2;

////Node node3 = new Node();
////node3.data = 75;
////node3.next = null;
////    node2.next = node3;

////Node node4 = new Node();
////node4.data = 85;
////node4.next = null;
////    node3.next = node4;


////Node node5 = new Node();
////node5.data = 95;
////node5.next = null;
////    node4.next = node5;

////Node Header = node1;

////while (Header != null)
////{
////    Console.WriteLine(Header.data);
////    Header = Header.next;

////}

////while (Header == null)
////{
////    Console.WriteLine(Header.data);

////}











//Console.ReadKey();
////Console.Write("Amount in the array: ");
////int length = Convert.ToInt32(Console.ReadLine());

////int[] Array = new int[length];

////for (int i = 0; i < length; i++)
////{
////    Console.Write("Pick your number: ");
////    Array[i] = Convert.ToInt32(Console.ReadLine());
////}

////recursive.DisplayArray(Array);

///*

//Create a aggregation (weak association) relationship between the mentioned below
//House - windows - doors
//Draw a diagram on paint
//*/


////Door door = new Door();
////Window window = new Window(door);
////House house = new House(window);




///*
////__________________________________________________________________________________________________________________________\\
//MultiLevel - Single Inheritance - Hierarchal
//Hierarchal = 1 parentClass and many ChildClasses
//MultiLevel = GranParentClass > ParentClass > ChildClass > GrandChildClass
//*/

////Mother mother = new Mother(" Mother");
////Daughter daughter = new Daughter(" Daughter");
////GrandDaughter gDaughter = new GrandDaughter(" Grand Daughter");


////gDaughter.Greetings();
////daughter.Greetings();
////mother.Greetings();







////Samsung samsung = new Samsung(1, "Samsung Galaxy A12");
////string displaySamsung = samsung.GetMobileInfo();
////Console.WriteLine(displaySamsung);



////Kitten kitten = new Kitten();
////string kittenName = kitten.GrandSon("Rambo");
////Console.WriteLine(kittenName);











////__________________________________________________________________________________________________________________________\\

////Factory factory = new Factory();
////Car car = factory.GetCarVehicle();


////string nameCar = car.VehicleInfo();
////Console.WriteLine(nameCar);


////string passName = factory.GetVehicle("rickshaw");     //I am a rickshaw
////Console.WriteLine(passName);


////Vehicle vehicleObject = factory.GetVehicleObject("rickshaw");
////string vehicleInfo = vehicleObject.VehicleInfo();
////Console.WriteLine(vehicleInfo);

////Vehicle rickshawObject = new Rickshaw();
////string name = rickshawObject.VehicleInfo();
////Console.WriteLine(name);




////__________________________________________________________________________________________________________________________\\
////int number1 = 8;
////int result = number1 % 2;
////Console.WriteLine(result);

////ChildMyMeth childMyMeth = new ChildMyMeth();

////bool result = childMyMeth.IsNumberEven(8);

////if (result == true)
////{
////    Console.WriteLine($"This number is even");
////}
////else
////{
////    Console.WriteLine($"This number is not even");
////}





////__________________________________________________________________________________________________________________________\\
////Create relation between Country and City and display several Cities. One to many. Country to Cities.
////Create Interface of countryClass - Inherit City from interface


////GenericClass<string> genericClassSTRING = new GenericClass<string>();
////genericClassSTRING.data = "Noah";
////Console.WriteLine(genericClassSTRING.data);

////GenericClass<int> genericClassINT = new GenericClass<int>();
////genericClassINT.data = 45;
////Console.WriteLine(genericClassINT.data);

////Database<string> dataBase = new Database<string>();
////dataBase.GenMethod("45", "Jonny");
////dataBase.GenData = "Sweden";
////Console.WriteLine(dataBase.GenData);

////Database<double> databaseDouble = new Database<double>();
////databaseDouble.GenMethod(4.3, 3.4);

////databaseDouble.GenData = 4.5;
////Console.WriteLine(databaseDouble.GenData);


////__________________________________________________________________________________________________________________________\\



////__________________________________________________________________________________________________________________________\\


////country - city - student - ICity
////City city = new City("Egypt", 123);



////Country country = new Country();
////country.DisplayCities();




////--------------------------------------------------------------------------------------------------------------------------\\


////CREATE AN INFERFACE OF "CITY". WITH 2 METHODS.
////FIRST METHOD(CITY ID, CITYNAME)
////SECOND METHOD = "DISPLAYCITY"
////CREATE 1 CLASS "CITY" AND INHERITE "CITY" FROM INTERFACE
////IN THE CITY CLASS INITIALIZE 2 FIELDS. CITYID AND CITYNAME
////IN THE PROGRAM.CS DISPLAY CITY AND CALL "SADCITY" METHOD
////DISPLAY CITY AGAIN
////CREATE RELATIONSHIP BETWEEN COUNTRY AND CITY


////__________________________________________________________________________________________________________________________\\
////Inheritance = Relationship "IS a"              Association = Relationship "HAS a"
////Association is a relationship between 2 different classes that are established through their objects (many-many) (1-many) (many-1) all are association
////Association =  1.Composition 2.Aggregation  << 

////CREATE A RELATION BETWEEN STUDENT AND COUNTRY
////Display studentName, studentCountry, and studentID


////--------------------------------------------------------------------------------------------------------------------------\\














////Association, Compisiton and Agregation


//// POLYMORPHISM has Static/CompileTime      and     Dynamic/Runtime Polymorphism        (operator overloading later)

////Static/CompileTime = same name and same type gives error or "method overloading".
////Employee employee = new Employee();
////string example1 = employee.EmployeeSalary(4.5);
////Console.WriteLine(example1);

////int example2 = employee.EmployeeSalary(55);
////Console.WriteLine(example2);

////Dynamic/Runtime = Method Overriding

////Employee fullTimeEmployee = new FullTimeEmployee();         //BaseClass creating a refence in the InheritedClass
////fullTimeEmployee.EmployeeName(" Mansour", "Mujahed ");
////fullTimeEmployee.EmployeeCompanyName();
////fullTimeEmployee.FullTimeEmployeeMethod();                  

////Employee partTimeEmployee = new PartTimeEmployee();
////partTimeEmployee.EmployeeName(" Jared", "Johnson ");

////IVehicle vehicle = new Vehicle();
////vehicle.VehicleName();
////vehicle.Doors();

////Doctor heartSurgeon = new HeartSurgeon();                   //BaseClass creating a refence in the InheritedClass
////heartSurgeon.Car();
////heartSurgeon.Specialization();
////heartSurgeon.DoctorDress();
////heartSurgeon.Age(45);
////ASSIGNMENT: practice inheritances. Abstract and interfaces, everything about it.


////int a = 30;
////int b = 50;

////Game game = new Game();
////game.Swap(ref a, ref b);

////||\\
////Console.WriteLine($"a = {a}");
////Console.WriteLine($"b = {b}");

////Fish fish = new Fish();
////fish.Name = "Julia";
////game.GameIsDancing(new Fish());
////Console.WriteLine(fish.Name);
////Console.WriteLine(fish.Age);




////   STACK       HEAP    //FROM STACK >> POINTING TOWARDS A HEAP
////Fish fish1 = new Fish(); //ADRESS X451 on a HEAP
////fish1.Name = "Julia";

////Fish fish2 = fish1;     //ADRESS X451 on a HEAP
////fish2.Name = "Barbara";

////Console.WriteLine($"fish1 name = {fish1.Name}"); // "Barbara"
////Console.WriteLine($"fish2 name = {fish2.Name}"); // "Barbara "

////Amazon.Example.Table table1 = new Amazon.Example.Table();

////Fish fish3 = new Fish(); //ADRESS X81






///*
//Vehicle vehicle = new Vehicle();
//vehicle.Wheels();
//vehicle.Windows(4);
//vehicle.Engine();
//                                              >>  INTERFACES here  <<
//int number1 = vehicle.Doors();
//Console.WriteLine(number1);
//string number2 = vehicle.Wipers(9);
//Console.WriteLine(number2);

//string VariableOne = vehicle.VehicleColor("Blue");
//Console.WriteLine(VariableOne);

//string VariableTwo = vehicle.VehicleName();
//Console.WriteLine(VariableTwo);
//*/




///* 
// We Checked: 

//sealed
//interface
//constructors "base" keyword
// */
















////FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
////fullTimeEmployee.EmployeeName("Noah","Amin");


////PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
////partTimeEmployee.EmployeeName("Salman","Khan");


////ContractEmployee contractEmployee = new ContractEmployee();
////contractEmployee.EmployeeName("Shahrukh", "Khan");













////       ***    HIGH IMPORTANCE LEVEL      ***

//// 1. Single inheritance = ParentClass only has one ChildClass
//// 2. HierarchalClass = If one single parent class has several child classes
//// 3. Multilevel inheritance GrandFather > Father > Son (chain)
//// C# Doesn't support multiple inheritance, it uses interfaces instead.

//// Inheritance can be indentified by the "IS - A" words (is a relationship)



///*//____________________________________________________________________
//OOP (Object-Oriented-Programming) has 4 principles/Rules.      I/

//1. Encapsulation = Hiding complexity behind functionalities    I/
//2. Abstraction = has abstract methods                                I/
//3. Inheritance =  In inheriance the parent class constructor is 
//                    called before the child class constructor    I/
//4. Polymorphism = static/dynamic change                                            I/
////--------------------------------------------------------------------*/