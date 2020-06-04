/*6.	Triples of Latin Letters
Write a program to read an integer n and print all triples of 
the first n small Latin letters, ordered alphabetically:
*/
using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char firstChar =  (char)('a' + i);
                        char SecondChar = (char)('a' + j);
                        char ThirdChar =  (char)('a' + k);
                        Console.Write(firstChar);
                        Console.Write(SecondChar);
                        Console.WriteLine(ThirdChar);
                    }
                }
            }
        }
    }
}