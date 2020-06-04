/*5.	Print Part of the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints 
part of the ASCII table of characters at the console.  
On the first line of input you will receive the char index you should start with and on the second line - 
the index of the last character you should print.
 */
using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int begging = int.Parse(Console.ReadLine());
            int finishing = int.Parse(Console.ReadLine());
            int currentChar = begging;

            for (int i = 0; i <= (finishing - begging); i++)
            {
                Console.Write($"{(char)currentChar} ");
                currentChar++;
            }



        }
    }
}
