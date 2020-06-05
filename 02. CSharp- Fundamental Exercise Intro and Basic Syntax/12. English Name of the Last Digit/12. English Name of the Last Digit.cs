/*2.	English Name of the Last Digit	
Write a method that returns the English name of the last digit of a given number. 
Write a program that reads an integer and prints the returned value from this method.
 */
using System;

namespace _12._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = input % 10;
            switch (num)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: Console.WriteLine("zero"); break;

            }
        }
    }
}
