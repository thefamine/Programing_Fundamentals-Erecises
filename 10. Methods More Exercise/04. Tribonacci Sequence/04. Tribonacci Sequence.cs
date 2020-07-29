/*4.	Tribonacci Sequence
In the "Tribonacci" sequence, every number is formed by the sum of the previous 3.
You are given a number num. Write a program that prints num numbers from the Tribonacci sequence,
each on a new line, starting from 1. The input comes as a parameter named num. The value num will always be positive integer.
*/
using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] output = new int[input];

            for (int i = 0; i < input; i++)
            {
                if (i == 0 || i == 1)
                { output[i] = 1; }
                else if (i == 2)
                { output[i] = 2; }
                else
                    output[i] = output[i - 1] + output[i - 2] + output[i - 3];
            }
            Console.WriteLine(String.Join(' ', output));

        }
    }
}
