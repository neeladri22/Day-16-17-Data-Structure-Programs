﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class PrimeNumber2Dimension
    {
        //Creating constructor
        public PrimeNumber2Dimension()
        {
        }
        public static void PrimeNumber()
        {
            PrimeNumber2Dimension p = new PrimeNumber2Dimension();
            int[,] arr = p.Fill2DArray();
            p.displayArray(arr);
        }
        //Creating Method for checking the number is prime number or not
        public bool IsPrime(int num)
        {
            int count = 1, i = 2;
            if (num == 1 || num == 0) return false;
            while (num / 2 >= i)
            {
                if (num % i == 0)
                    count++;
                if (count >= 2)
                    return false;
                i++;
            }
            return true;
        }
        //creating method for counting the prime numbers
        public int countPrime(int m, int n)
        {
            int count = 0;
            if (m > n)
            {
                int t = m;
                m = n;
                n = t;
            }
            for (int i = m; i <= n; i++)
            {
                if (IsPrime(i)) count++;
            }
            return count;
        }
        public int[,] Fill2DArray()
        {
            int[,] array = new int[20, 30];
            int m = 0, n = 100;
            for (int i = 0; i < array.GetLength(0) && n <= 1001; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = m, k = 0; j < n; j++)
                    {
                        if (IsPrime(j))
                        {
                            array[i, k++] = j;
                        }
                    }
                    m = n; n = n + 100;
                }
                else
                { array[i, 0] = m; array[i, 1] = n; }
            }
            return array;
        }
        //Creating the method for display the prime numbers
        public void displayArray(int[,] a)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Prime Numbers in the Range " + a[i, 0] + " to " + a[i, 1] + " are :");
                }
                else
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] != 0)
                        {
                            Console.Write(a[i, j] + " ");
                        }
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
