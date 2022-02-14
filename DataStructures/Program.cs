using System;
using System.Collections;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Pop();
            stack.Display();
            Console.ReadLine();
        }
    }
    
}
