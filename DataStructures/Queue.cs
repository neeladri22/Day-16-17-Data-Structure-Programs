using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Queue<T>
    {
        int capacity;
        string[] obj;
        int front = -1, rear = -1;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            obj = new string[capacity];
        }
        // create method for adding the string data into queue
        public bool Enqueue(string data)
        {
            if (rear == capacity - 1)
            {
                Console.WriteLine("Que is Full");
                return false;
            }
            if (rear == -1)
                front++;
            obj[++rear] = data;
            return true;
        }
        // create method for remove the string data from queue
        public string Dequeue()
        {
            if (front == -1)
            {
                Console.WriteLine("que is empty");
                return default(string);
            }
            string ob = obj[front++];
            if (front > rear)
                front = rear = -1;
            return ob;
        }
        //Creating method for checking its is empty or not
        public bool IsEmpty()
        {
            if (rear == -1)
                return true;
            else return false;
        }
        // creating method for checking the size of the queue
        public int Size()
        {
            if (rear == -1)
            {
                return 0;
            }
            return rear - front + 1;
        }
        public override string ToString()
        {
            String s = "";
            for (int i = front; i <= rear && front != -1; i++)
            {
                s = s + obj[i] + " ";

            }
            return s;
        }
    }
}
