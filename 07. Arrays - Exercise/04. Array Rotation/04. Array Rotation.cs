/*4.	Array Rotation
Write a program that receives an array and number of rotations you have to perform
(first element goes at the end) Print the resulting array.
*/
using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstElement = inputArray[0];
                for (int j=0;j<inputArray.Length-1;j++ )
                { inputArray[j] = inputArray[j + 1]; }
                inputArray[inputArray.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ",inputArray));
        }
    }
}
