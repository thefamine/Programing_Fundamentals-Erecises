/*1.	Sign of Integer Numbers
Create a method that prints the sign of an integer number n:
 */ 
 using System;

namespace _09._Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
                SignOfIntegerNumbers(input);
        }

        static void SignOfIntegerNumbers(int a)
        {
            if (a > 0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
           else if (a < 0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {a} is zero.");
            }
        }

    }
}
