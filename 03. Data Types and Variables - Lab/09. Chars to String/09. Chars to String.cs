/*9.	Chars to String
Write a program that reads 3 lines of input. 
On each line you get a single character. C
ombine all the characters into one string and print it on the console.

 */
using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char input ='a';
 
            for (int i = 0; i <= 2; i++)
            {
                input = char.Parse(Console.ReadLine());
             Console.Write(input);
            }
        }
    }
}
