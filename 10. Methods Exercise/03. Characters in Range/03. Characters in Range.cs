/*3.	Characters in Range
Write a method that receives two characters and prints on a single line all the characters in
between them according to ASCII.
*/
using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintASCIICHars(start, end);

        }
        static void PrintASCIICHars(char start, char end)
        {
            char temp;
            if (start > end)
            {
                temp = start;
                start = end;
                end =temp;
               
            }
            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }

        }

    }
}
