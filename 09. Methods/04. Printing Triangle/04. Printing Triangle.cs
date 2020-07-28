/*4.	Printing Triangle
Create a method for printing triangles as shown below:
Input	Output
3	1
    1 2
    1 2 3
    1 2
    1
       */
using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                PrintNumbersTo(i + 1);
            }
           for (int i = input; i > 1; i--)
            {
                PrintNumbersTo(i - 1);
            }



        }

        static void PrintNumbersTo(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write($"{i+1} ");
            }
            Console.WriteLine();
        }
    }
}
