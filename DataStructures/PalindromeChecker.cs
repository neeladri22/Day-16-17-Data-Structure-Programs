using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class PalindromeChecker
    {
        public static void checkPalindrome()
        {
            Console.WriteLine("Enter the String to check for Palindrome:");
            string st = Console.ReadLine();
            isPalindrome(st);
        }
        public static bool isPalindrome(string st)
        {
            Deque<char> q = new Deque<char>();
            for (int i = 0; i < st.Length; i++)
                q.AddRear(st[i]);


            while (!q.IsEmpty())
            {
                if (q.Size() == 1)
                    break;
                if (!(q.RemoveFront().Equals(q.RemoveRear())))
                {
                    Console.WriteLine("given String is Not Palindrome");
                    return false;
                }
            }
            Console.WriteLine("Given String is Palindrome");
            return true;
        }
    }
}
