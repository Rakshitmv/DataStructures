using DataStructures.Queue;
using System;
using System.Collections;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queues queue = new Queues();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();
        }
    }
    
}
