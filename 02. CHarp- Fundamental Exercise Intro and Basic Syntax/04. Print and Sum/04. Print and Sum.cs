/*4.	Print and Sum
Write a program to display numbers from given start to given end and their sum. All the numbers will be integers. On the first line you will receive the start, on the second the end.
*/
using System;

namespace _04._Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = start;
            Console.Write($"{start} ");
            for (int i = start; i < end; i++)
            {
                start++;
                sum+=start;
                Console.Write($"{start} ");
            }
            Console.WriteLine();
            Console.Write($"Sum: {sum}");

        }
    }
}
