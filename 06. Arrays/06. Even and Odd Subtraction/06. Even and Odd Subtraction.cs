﻿using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                { sumEven += input[i]; }
                else
                { sumOdd += input[i]; }
            }

            Console.WriteLine(sumEven-sumOdd);
        }
    }
}
