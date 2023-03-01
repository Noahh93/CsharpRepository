using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastructure;


Node node1 = new Node();
node1._data = 10;
node1._next = null;

Node node2 = new Node();
node2._data = 20;
node2._next = null;
node1._next = node2;

Node node3 = new Node();
node3._data = 30;
node3._next = null;
node2._next = node3;

Node node4 = new Node();
node4._data = 13;
node4._next = node1;
node3._next = node4;


Node headerForward = node1;

LinkedList lL = new LinkedList();
//lL.Display(headerForward);
//lL.DeleteNode(headerForward, 20);
//lL.Display(headerForward);
//int storedVariable = lL.SearchElementNodePosition(headerForward, 40);

//Console.WriteLine("This is node = " + storedVariable);

int totalNode = lL.TotalNodes(headerForward);
//Console.WriteLine(totalNode);

//int findTotalDublicateData = lL.FindTotalDublicateData(headerForward, 10);
//Console.WriteLine(findTotalDublicateData);

lL.EvenOrOdd(headerForward);




Console.ReadKey();