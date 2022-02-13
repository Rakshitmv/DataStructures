using DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode list = new LinkedListNode();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.AddInReverseOrder(10);
            list.AddInReverseOrder(20);
            list.AddInReverseOrder(30);
            int pos = list.Search(20);
            int requiredPos = list.Search(10);
            list.RemoveFirstNode(1);
            list.RemoveLastNode();
            list.Search(20);
            if (pos == -1)
            {
                Console.WriteLine("Element is not present in the list");
            }
            else
            {
                Console.WriteLine(pos);
            }
            list.DeleteNodeAtParticularPosition(pos);
            list.Display();
            list.Size();
            Console.ReadLine();
        }
    }
    
}
