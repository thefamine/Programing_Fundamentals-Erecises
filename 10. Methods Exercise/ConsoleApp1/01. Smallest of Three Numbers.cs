using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int min = ReturnMinOfThree(num1,num2,num3);
            Console.WriteLine(min);
        }

        static int ReturnMinOfThree(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
