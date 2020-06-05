﻿/*6.	Equal Sums
Write a program that determines if there exists an element in the array such that the sum of the elements on its left is equal to the sum of the elements on its right
(there will never be more than 1 element like that). If there are no elements to the left / right, their sum is considered to be 0. Print the index that satisfies the
required condition or "no" if there is no such index.

 */
using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isIndex = false;
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int sumLeft = 0;
                if (i != 0)
                {
                    for (int j = 0; j < i; j++)
                    { sumLeft += input[j]; }
                }
                int sumRight = 0;
                if (i != input.Length)
                {
                    for (int k = i+1; k < input.Length; k++)
                    { sumRight += input[k]; }
                }
                if (sumLeft == sumRight)
                {
                    isIndex = true;
                    index = i;
                    break;
                }
            }
            if (isIndex)
                Console.WriteLine(index);
            else
                Console.WriteLine("no");
        }
    }
}
