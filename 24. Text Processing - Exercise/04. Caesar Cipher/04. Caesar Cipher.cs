using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
             output.Append((char)(input[i] + 3));
            }
            Console.WriteLine(output);
        }
        static int CharCodesMultiplied(char a, char b)
        {
            int sum = a * b;
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
