﻿/*3.	Exact Sum of Real Numbers
Write program to enter n numbers and calculate and print their exact sum (without rounding).
 */
using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i=0; i<n;i++)
            {
                decimal current = decimal.Parse(Console.ReadLine());
                    sum += current;
            }
            Console.WriteLine(sum);
        }
    }
}