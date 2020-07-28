/*10.	Multiply Evens by Odds
Create a program that multiplies the sum of all even digits of a number 
by the sum of all odd digits of the same number:
•	Create a method called GetMultipleOfEvenAndOdds()
•	Create a method GetSumOfEvenDigits()
•	Create GetSumOfOddDigits()
•	You may need to use Math.Abs() for negative numbers

 */
using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Math.Abs(int.Parse(Console.ReadLine())).ToString();
            Console.WriteLine(GetSumOfEvenDigits(input) * GetSumOfOddDigits(input));
        }

        static int GetSumOfEvenDigits(string a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = int.Parse(a[i].ToString());
                if (temp % 2 == 0)
                { sum += temp; }
            }
            return sum;
        }
        static int GetSumOfOddDigits(string a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = int.Parse(a[i].ToString());
                if (temp % 2 == 1)
                { sum += temp; }
            }
            return sum;
        }
    }

}

