/*1.	Encrypt, Sort and Print Array
Write a program that reads a sequence of strings from the console. Encrypt every string by summing:
•	The code of each vowel multiplied by the string length
•	The code of each consonant divided by the string length
Sort the number sequence in ascending order and print it on the console.
On first line, you will always receive the number of strings you have to read.
*/
using System;
using System.Linq;

namespace _07._Arrays___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int strinNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[strinNumbers];
            for (int i = 0; i < strinNumbers; i++)
            {

                string Name = Console.ReadLine();
                int sumCode=0;
                char[] vowels = new char[] { 'a', 'A', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
                for (int j = 0; j < Name.Length; j++)
                {
                    char curChar = Name[j];

                    if (vowels.Contains(curChar))
                    { sumCode += curChar * Name.Length; }
                    else
                    { sumCode += curChar / Name.Length; }
                }
                numbers[i] = sumCode;

            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
