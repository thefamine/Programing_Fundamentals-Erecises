/*2.	Pascal Triangle
The triangle may be constructed in the following manner: In row 0 (the topmost row), there 
is a unique nonzero entry 1. Each entry of each subsequent row is constructed by adding the number 
above and to the left with the number above and to the right, treating blank entries as 0. For example, 
the initial number in the first (or any other) row is 1 (the sum of 0 and 1), whereas the numbers 1 and 3 
in the third row are added to produce the number 4 in the fourth row.
If you want more info about it: https://en.wikipedia.org/wiki/Pascal's_triangle
Print each row elements separated with whitespace.

 */
using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[] { 1 };

            Console.WriteLine(String.Join(' ', firstArray));

            if (n > 1)
            {
                int[] tempArray = firstArray;
                for (int i = 1; i < n; i++)
                {
                    int[] arrayBase = new int[i + 1];
                    arrayBase[0] = 1;
                    arrayBase[arrayBase.Length - 1] = 1;

                    for (int j = 1; j < i; j++)
                    {
                        arrayBase[j] = tempArray[j - 1] + tempArray[j];
                    }
                    Console.WriteLine(String.Join(' ', arrayBase));
                    tempArray = arrayBase;
                }
            }
        }
    }
}
