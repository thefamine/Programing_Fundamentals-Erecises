/*5.	Multiply Big Number
You are given two lines – the first one can be a really big number (0 to 1050). 
The second one will be a single digit number (0 to 9). You must display the product of these numbers.
Note: do not use the BigInteger class.
*/
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            if (second == 0)
            { Console.WriteLine("0"); 
                return; }


            while (first[0] == '0')
            { first=first.Substring(1); }

       
            StringBuilder sb = new StringBuilder();
            int remainder = 0;
            for (int i = first.Length-1; i >=0; i--)
            {
                int result = int.Parse(first[i].ToString()) * second+remainder;
                remainder = 0;
                if (result > 9)
                { remainder = result / 10;
                    result = result % 10;
                }
                sb.Append(result);
            }
            if (remainder != 0)
            { sb.Append(remainder); }


            StringBuilder reverse = new StringBuilder();
            for (int i = sb.Length-1; i >=0; i--)
            {
                reverse.Append(sb[i]);

            }
            Console.WriteLine(reverse);

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
