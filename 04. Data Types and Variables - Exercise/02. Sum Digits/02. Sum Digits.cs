/*2.	Sum Digits
You will be given a single integer. 
Your task is to find the sum of its digits
 */
using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int currentDigit = input;
            int sum = 0;

            while (currentDigit != 0)
            {   sum += currentDigit % 10;
                currentDigit /= 10;       }
            Console.WriteLine(sum);
        }
    }
}
