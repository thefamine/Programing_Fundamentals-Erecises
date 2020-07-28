/*8.	Math Power
Create a method that calculates and returns the value of a number raised to a 
given power: */
using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal baseN = decimal.Parse(Console.ReadLine());
            int Power = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(baseN,Power));

        }
        static decimal MathPower(decimal baseN, int Power)
        {
            decimal result = 1;
            for (int i = 0; i < Power; i++)
            {
                result *=baseN;
            }

            return result;
        }
    }
}
