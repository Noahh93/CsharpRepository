
using Amazon.Example;
using Amazon.Example.Inheritance;
using Amazon.examples.Inheritance;
using System.Data.Common;
using System.Runtime.CompilerServices;
using BusinessLayer;
using Amazon.Ecommerce;

Kitten kitten = new Kitten(1234, 12, "Noah", "Nigeria", "NigeriaCapital");



kitten.Dance(); //Inherited from Cat - Kitten
kitten.Jump();  //Inherited from Animal - Cat - Kitten
kitten.KittenName("JULIA");
kitten.DisplayDetail();


Console.ReadKey();

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