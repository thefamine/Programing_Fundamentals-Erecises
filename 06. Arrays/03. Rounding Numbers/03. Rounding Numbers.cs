/*3.	Rounding Numbers
Read an array of real numbers (space separated), round them in "away from 0" style and print the output as in the examples:
 */
using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedNums = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(input[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < roundedNums.Length; i++)
            {
                if (input[i] != -0)
                    Console.WriteLine($"{input[i]} => {roundedNums[i]}");
                else
                    Console.WriteLine($"0 => 0");
            }
        }
    }
}
