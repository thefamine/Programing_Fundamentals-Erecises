/*7.	Max Sequence of Equal Elements
Write a program that finds the longest sequence of equal elements in an array of integers. 
If several longest sequences exist, print the leftmost one.

 
*/
using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int number = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int tempNumber = input[i];
                int countTemp = 1;
                for (int j = 1; j < input.Length - i ; j++)
                {
                    if (tempNumber != input[i + j])
                    { break; }
                    countTemp++;


                }

                if (countTemp > count)
                {
                    count = countTemp;
                    number = tempNumber;
                }

            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{number} ");

            }
        }
    }
}
