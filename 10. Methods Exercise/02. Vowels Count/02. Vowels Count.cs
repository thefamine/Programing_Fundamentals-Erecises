/*2.	Vowels Count
Write a method that receives a single string and prints the count of the vowels.
Use appropriate name for the method.
*/
using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            CountVowels(text);
        }

        static void CountVowels(string text)
        {
            int vowelsCounter = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                { vowelsCounter++; }
            }
            Console.WriteLine(text);
        }
    }
}
