/*5.	Word Filter
Read an array of strings and take only words, whose length is even. Print each word on a new line.
 */ 
using System;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

        }
    }
}
