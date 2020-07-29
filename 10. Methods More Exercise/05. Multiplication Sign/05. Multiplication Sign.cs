/*5.	Multiplication Sign
You are given a number num1, num2 and num3.Write a program that finds if num1* num2 * num3 (the product) is negative,
positive or zero.Try to do this WITHOUT multiplying the 3 numbers.
*/
using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            if (IsZero(first, second, third))
            { Console.WriteLine("zero"); }
            else if (IsNegative(first, second, third))
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");

        }
        static bool IsZero(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            { return true; }
            else
                return false;
        }
        static bool IsNegative(double first, double second, double third)
        {
            string input = first.ToString() + second.ToString() + third.ToString();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-')
                { counter++; }
            }
            if (counter % 2 == 0)
            { return false; }
            else
                return true;

        }
    }
}
