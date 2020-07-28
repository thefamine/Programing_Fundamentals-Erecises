/*2.	Odd Occurrences
Write a program that extracts all elements from a given sequence of words that are present in it an 
odd number of times (case-insensitive).
•	Words are given on a single line, space separated.
•	Print the result elements in lowercase, in their order of appearance.
*/
using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase]++;
                }
                else 
                {
                    counts.Add(wordInLowerCase, 1);
                }
            }

            foreach (var count in counts)
            {
                if (!(count.Value % 2 == 0))
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
