/*8.	Magic Sum
Write a program, which prints all unique pairs in an array of integers whose sum is equal to a 
given number.
*/
using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {

                for (int j = i+1; j < input.Length - i; j++)
                {
                    if (input[i] + input[j] == sum)
                    { Console.WriteLine($"{input[i]} {input[j]}"); }
                }
            }
        }
    }
}
