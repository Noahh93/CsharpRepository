using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datastructure
{
    public class LinkedList
    {
        public LinkedList() 
        {

        }
        public void Recieve()
        {
            Node node1 = new Node();
            node1._data = 10;
            node1._next = null;

            Node node2 = new Node();
            node2._data = 20;
            node2._next = null;
            node1._next = node2;

            Node node3 = new Node();
            node3._data = 10;
            node3._next = null;
            node2._next = node3;

            Node node4 = new Node();
            node4._data = 40;
            node4._next = node1;
            node3._next = node4;

            Node headerForward = node1;
            
        }
        public void Display(Node headerForward)
        {
            Node node1 = headerForward;
            while (headerForward != null)
            {
                Console.WriteLine(headerForward._data);
                headerForward = headerForward._next;
                if (headerForward == node1)
                {
                    break;
                }
            }
        }
        public void DeleteNode(Node headerForward, int data)
        {
            Node node2 = headerForward;
            while (headerForward != null)
            {
                headerForward = headerForward._next;
                if (headerForward == node2)
                {
                    data = 0;
                }
            }
        }
        public int SearchElementNodePosition(Node headerForward, int data)
        {
            int nodePosition = -1;
            Node node1 = headerForward;
            while ( headerForward != null)
            {
               if (headerForward._data == data)
               {
                    nodePosition = nodePosition + 2;
                    break;
               }
                headerForward = headerForward._next;
                if (headerForward == node1)
                {
                   break;
                }
               nodePosition++;
            }
            if (headerForward._data != data)
            {
                return -1;
            }

            return nodePosition;
        }
        public int TotalNodes(Node headerForward)
        {
            int nodeAmounts = 0;
            Node node1 = headerForward;
            while (headerForward != null)
            {
                nodeAmounts++;
                headerForward = headerForward._next;
                if (headerForward == node1)
                {
                    break;
                }
            }
            return nodeAmounts;
        }
        public int FindTotalDublicateData(Node headerForward, int data)
        {
            int dataResult = 0;

            Node node1 = headerForward;

            while (headerForward != null)
            {
                if (headerForward._data == data)
                {
                    dataResult++;
                }
                headerForward = headerForward._next;
                if (headerForward == node1)
                {
                    break;
                }
            }
            return dataResult++;
        }
        public void EvenOrOdd(Node headerForward)
        {//display the data in linkedList. "This {_data} is even/odd" 

            int even = 0;
            int odd = 0;

            Node node1 = headerForward;
            while (headerForward != null)
            {
                headerForward = headerForward._next;
                if (headerForward._data % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                if (headerForward == node1)
                {
                    break;
                }
            }
            Console.WriteLine("There are " + even + " even numbers and " + odd + " odd.");
        }
    }
}