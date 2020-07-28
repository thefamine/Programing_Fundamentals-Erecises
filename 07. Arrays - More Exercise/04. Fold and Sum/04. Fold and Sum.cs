/*Read an array of 4*k integers, fold it like shown below, and print the sum of the upper
 * and lower two rows (each holding 2 * k integers):*/

using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] secondArray = new int[input.Length / 2];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = input[input.Length / 4+ i];
            }

            int[] firstArray = new int[input.Length / 2];
            int j = firstArray.Length / 2-1;
            for (int i = 0; i < firstArray.Length; i++)
            {


                if (i < firstArray.Length / 2)
                {
                    firstArray[i] = input[j];
                    j--;
                }
                else
                {
                    if (i == firstArray.Length / 2)
                    { j = firstArray.Length / 2 - 1; }
                    firstArray[i] = input[input.Length*3/4+j];
                    j--;
                }
              
     
         
            }


            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"{firstArray[i] + secondArray[i]} ");
            }

        }
    }
}
