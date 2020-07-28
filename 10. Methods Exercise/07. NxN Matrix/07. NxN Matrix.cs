/*7.	NxN Matrix
Write a method that receives a single integer N and prints NxN matrix with that number.
 */
using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintNxNMatrixFrom(input);
        }
        static void PrintNxNMatrixFrom(int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input - 1; j++)
                {
                    Console.Write($"{input} ");
                }
                Console.WriteLine(input);
            }
        }

    }
}

