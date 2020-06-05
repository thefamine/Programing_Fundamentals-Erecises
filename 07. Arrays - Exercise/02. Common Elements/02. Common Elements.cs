/*2.	Common Elements
Write a program, which prints common elements in two arrays. You have to compare the elements of the second array to the elements of the first.
*/
using System;
using System.Linq;
namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split();
            var SecondArray = Console.ReadLine().Split();

            for (int i = 0; i < SecondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (firstArray[j] == SecondArray[i])
                    {
                        Console.Write($"{SecondArray[i]} ");
                    }
                }
            }
        }
    }
}
