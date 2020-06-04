/*6.	Reversed Chars
Write a program that takes 3 lines of characters and prints them 
in reversed order with a space between them.

 */
using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            for (int i = 0; i <= 2; i++)
            {input += Console.ReadLine();}


            for (int i = 2; i>=0;i--)
            Console.Write($"{input[i]} ");
        }
    }
}
