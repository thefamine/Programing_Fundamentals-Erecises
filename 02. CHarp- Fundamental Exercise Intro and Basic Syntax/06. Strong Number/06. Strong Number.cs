/*6.	Strong Number
Write a program to check if a given number is a strong number or not. A number is strong if the sum of the Factorial of each digit is equal to the number. 
For example 145 is a strong number, because 1! + 4! + 5! = 145. Print "yes" if the number is strong and "no" if the number is not strong.
*/
using System;

namespace _06._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numS = Console.ReadLine();
            int num = int.Parse(numS);
            int sum = 0;
            int tempNumber = int.Parse(numS);

            for (int i = 1; i<=numS.Length; i++)
            {
                int currentDigit = tempNumber % 10;
                tempNumber /= 10;
                int factoriqal = 1;
                for (int j = 1; j <= currentDigit&& currentDigit!=0; j++)
                {
                    factoriqal *= j;
                }
                sum += factoriqal;
            }
            if (sum == num)
            { Console.WriteLine($"yes"); }
            else
            { Console.WriteLine($"no"); }
        }
    }
}
