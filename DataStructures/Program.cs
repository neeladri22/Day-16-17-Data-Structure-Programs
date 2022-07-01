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

        }
       
    }
}
