/*2.	 Character Multiplier
Create a method that takes two strings as arguments and returns the sum of their character codes
multiplied (multiply str1[0] with str2[0] and add to the total sum). 
Then continue with the next two characters. If one of the strings is longer than the other,
add the remaining character codes to the total sum without multiplication.
*/
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input= Console.ReadLine().Split();
            string firstString = input[0];
            string secondString = input[1];
            int sum = 0;
            for (int i = 0; i < Math.Min(firstString.Length,secondString.Length); i++)
            {
                sum+=CharCodesMultiplied(firstString[i], secondString[i]);
            }
            if (firstString.Length > Math.Min(firstString.Length, secondString.Length))
            {
                for (int i = Math.Min(firstString.Length, secondString.Length); i < firstString.Length; i++)
                {
                    sum += firstString[i];
                }
            }
            if (secondString.Length > Math.Min(firstString.Length, secondString.Length))
            {
                for (int i = Math.Min(firstString.Length, secondString.Length); i < secondString.Length; i++)
                {
                    sum += secondString[i];
                }
            }

            Console.WriteLine(sum);


        }
        static int CharCodesMultiplied(char a, char b)
        {   int sum = a * b;
            return sum;
        }


        static List<int> ReadIntListSingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }

        static List<double> ReadDoubleListSingleLine()
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
            return list;
        }

        static List<string> ReadStringListSingleLine()
        {
            List<string> list = Console.ReadLine().Split().ToList();
            return list;
        }

        static void PrintIntListSingleLine(List<int> numbers, string a)
        { Console.WriteLine(string.Join(a, numbers)); }

        static void PrintDoubleListSingleLine(List<double> numbers, string a)
        { Console.WriteLine(string.Join(a, numbers)); }

        static void PrintStringListSingleLine(List<string> numbers, string a)
        { Console.WriteLine(string.Join(a, numbers)); }
    }
}

   
