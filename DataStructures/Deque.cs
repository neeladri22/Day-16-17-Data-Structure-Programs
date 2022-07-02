using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Deque<T>
    {
        // Craeting the Node class
        public class Node
        {
            public char data;
            public Node pre;
            public Node next;
            public Node(char data)
            {
                this.data = data;
            }

        }
        public Node head;
        //creating method to add element at front
        public void AddFront(char data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return;
            }
            n.next = head;
            head.pre = n;
            head = n;
            return;
        }
        //creating method to add element at last
        public void AddRear(char data)
        {

            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return;
            }
            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            n.pre = t;
            return;
        }
        //creating method to remove element from front
        public char RemoveFront()
        {
            if (head == null)
            {
                Console.WriteLine("que is Empty");
                return default;
            }
            char data = head.data;
            head = head.next;
            return data;
        }
        //creating method to remove element from last
        public char RemoveRear()
        {
            if (head == null)
            {
                Console.WriteLine("Deque is Empty");
                return default;
            }
            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            char data = t.data;
            t.pre.next = null;
            return data;
        }
        //creating method to check it is empty or not
        public bool IsEmpty()
        {
            if (head == null)
                return true;
            else return false;
        }
        //creating the method for checking the size
        public int Size()
        {
            int count = 0;
            if (head == null)
                return count;
            Node t = head;
            while (t != null)
            {
                t = t.next;
                count++;
            }
            return count;
        }
        public override string ToString()
        {
            string s = "";
            Node t = head;
            while (t != null)
            {
                s = s + t.data + " ";
                t = t.next;
            }
            return s;
        }

    }
}
