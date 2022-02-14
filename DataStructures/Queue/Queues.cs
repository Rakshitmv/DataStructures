using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    public class Queues
    {
        public Node head;
        public Node Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                return head;
            }
            else
            {
                Node Temp = head;
                while (Temp.next != null)
                {
                    Temp = Temp.next;
                }
                Temp.next = newnode;
                return head;
            }
        }
        public Node Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is  Empty");
                return head;
            }
            else
            {
                Console.WriteLine(head.data + "deleted from Queue");
                head = head.next;
                return head;
            }
        }

        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data);
                    temp = temp.next;
                }
            }
            Console.WriteLine("");
        }
    }
}
