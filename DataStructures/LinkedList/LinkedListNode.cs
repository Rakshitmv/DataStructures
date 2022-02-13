using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class LinkedListNode
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked list", node.data);
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = temp;
                head.next = temp;
            }
        }
        public Node RemoveFirstNode(int data)
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public int Search(int data)
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                if (temp.data == data) return count;
                temp = temp.next;
                count++;
            }
            return -1;
        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if ((temp.next == null) || (temp.next == null))
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            Size();
        }
        public void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of linkedList is : " + " " + count);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp.next != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
    }
}
