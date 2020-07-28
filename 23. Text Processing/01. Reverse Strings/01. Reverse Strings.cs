/*1.	Reverse Strings
You will be given series of strings until you receive an "end" command. 
Write a program that reverses strings and prints each pair on separate 
line in format "{word} = {reversed word}".
 */
using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string reversed = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }
                Console.WriteLine($"{input} = {reversed}");

                input = Console.ReadLine();

            }

        }
    }
}
