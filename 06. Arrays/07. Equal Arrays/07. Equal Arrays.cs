/*7.	Equal Arrays
Read two arrays and print on the console whether they are identical or not. 
Arrays are identical if their elements are equal. If the arrays are identical 
find the sum of the first one and print on the console following message: "Arrays are identical. 
Sum: {sum}", otherwise find the first index where the arrays differ and print on the console 
following message: "Arrays are not identical. Found difference at {index} index".
*/

using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputFirst = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] inputSecond = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int differnces = 0;
            int sum = 0;
            bool dif = false;

            for (int i = 0; i < inputFirst.Length; i++)
            {
                if (inputFirst[i] != inputSecond[i])
                { dif = true; }
                else
                {
                    sum += inputFirst[i];
                    differnces++;
                }
            }

            if (dif)
                Console.WriteLine($"Arrays are not identical. Found difference at {differnces} index");
            else
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
