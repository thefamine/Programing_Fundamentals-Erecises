/*4.	Largest 3 Numbers
Read a list of integers and print the largest 3 of them. If there are less than 3, print all of them.
*/
using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().OrderByDescending(n=>n).Select(int.Parse).ToArray();
            for (int i = 0; i < 3; i++)
            {if (i >= numbers.Length)
                { break; }
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
