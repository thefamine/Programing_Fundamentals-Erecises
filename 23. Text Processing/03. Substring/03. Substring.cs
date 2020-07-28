/*On the first line you will receive a string. 
 On the second line you will receive a second string. 
 Write a program that removes all of the occurrences of the first string in the second until there is no match. 
 At the end print the remaining string.
 */
using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();
            int index = text.IndexOf(key);
            while (index != -1)
            { text = text.Remove(index, key.Length);
                index = text.IndexOf(key);
            }
            Console.WriteLine(text);
        }
    }
}
