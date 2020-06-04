/*
 6.	Foreign Languages
Write a program, which prints the language, that a given country speaks. 
You can receive only the following combinations: 
English is spoken in England and USA; 
Spanish is spoken in Spain, Argentina and Mexico; 
for the others, we should print "unknown".

Input
You will receive a single country name on a single line.

Output
Print the language, which the country speaks, or if it is unknown for your 
program, print "unknown".
*/
using System;

namespace _6._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            switch (country)
            {
                case "England":
                    Console.WriteLine("English");
                    break;
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
        
                default:
                    Console.WriteLine("unknown");
                    break;

            }
        }
    }
}
