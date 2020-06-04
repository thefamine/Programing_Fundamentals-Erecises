/*8.	Condense Array to Number
Write a program to read an array of integers and condense them by summing adjacent couples of 
elements until a single integer is obtained. For example, if we have 3 elements {2, 10, 3}, we sum 
the first two and the second two elements and obtain {2+10, 10+3} = {12, 13}, then we sum again all 
adjacent elements and obtain {12+13} = {25}.

 */
using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (input.Length != 1)
            {
                int[] condensed = new int[input.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {condensed[i] = input[i] + input[i + 1];}
                input = condensed;
            }
            Console.WriteLine(input[0]);
        }
    }
}
