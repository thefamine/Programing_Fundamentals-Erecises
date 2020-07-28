﻿/*3.	Recursive Fibonacci
The Fibonacci sequence is quite a famous sequence of numbers. Each member of the sequence is calculated from
the sum of the two previous elements. The first two elements are 1, 1. Therefore the sequence goes 
as 1, 1, 2, 3, 5, 8, 13, 21, 34…
The following sequence can be generated with an array, but that’s easy, so your task is to implement recursively.
So if the function GetFibonacci(n) returns the n’th Fibonacci number we can express it using GetFibonacci(n) = GetFibonacci(n-1) + GetFibonacci(n-2).
However, this will never end and in a few seconds a StackOverflow Exception is thrown. In order for the recursion to stop it has to have a “bottom”. The bottom of the recursion is GetFibonacci(2) should return 1 and GetFibonacci(1) should return 1.
Input Format:
•	On the only line in the input the user should enter the wanted Fibonacci number.
Output Format:
•	The output should be the n’th Fibonacci number counting from 1.
Constraints:
•	1 ≤ N ≤ 50
*/
using System;

namespace ConsoleApp103._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibonN = 1;
            int[] FibonacciArray = new int[n];
            FibonacciArray[0] = 1;

            for (int i = 1; i < n; i++)
            {
                if (i > 1)
                    FibonacciArray[i] = FibonacciArray[i - 1] + FibonacciArray[i - 2];
                else
                    FibonacciArray[i] = FibonacciArray[i - 1];
            }
            Console.WriteLine(FibonacciArray[FibonacciArray.Length-1]);
        }
    }
}
