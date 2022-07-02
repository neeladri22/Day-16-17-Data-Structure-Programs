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

            Console.WriteLine("Welcome to Ordered List program");
            OrderList r = new OrderList();
           
            r.addFirst(22);
            r.addFirst(33);
            r.addFirst(11);
            r.addFirst(55);
            r.addFirst(44);
            r.addFirst(66);
            r.addFirst(88);

            Console.WriteLine("Enter  number:");
            int input = int.Parse(Console.ReadLine());

            bool check = r.search(input);

            if (check == true)
            {
                r.remove(input);
            }
            else
            {
               
                r.addFirst(input);
            }

            r.diplayData();

            /*
            Console.WriteLine("Welcome to Unordered List program");
            UnOrderList r = new UnOrderList();
            r.addFirst("Neeladri");
            r.addFirst("Vamsi");
            r.addFirst("Laxman");
            r.addFirst("Hema");
            r.addFirst("Varsa");
            r.addFirst("Hemanth");
            r.addFirst("Mohan");

            string input = Console.ReadLine();
            bool check = r.search(input);
            if (check == true)
            {
                r.delete(input);
            }
            else
            {
                r.addFirst(input);
            }

            r.diplayData();

            */

        }
       
    }
}
