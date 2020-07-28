/*4.	Text Filter
Write a program that takes a text and a string of banned words. 
All words included in the ban list should be replaced with asterisks "*", 
equal to the word's length. The entries in the ban list will be separated by 
a comma and space ", ".
The ban list should be entered on the first input line 
and the text on the second input line. 

 */
using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();
            foreach (var word in words)
            {
                if (input.Contains(word))
                {
                    input = input.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(input);
        }
    }
}
