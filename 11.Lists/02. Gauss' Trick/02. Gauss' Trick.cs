/*2.	Gauss' Trick
Write a program that sums all of the numbers in a list in the following order: 
first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadIntListSingleLine(); 

            Console.WriteLine(string.Join(' ',SumAdjacentEqualNumbers(numbers)));

        }


        static List<int> SumAdjacentEqualNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1 - i];
            }
            if(numbers.Count%2==1)
            numbers.RemoveRange(numbers.Count / 2 + 1, numbers.Count / 2);
            else
            numbers.RemoveRange(numbers.Count / 2, numbers.Count / 2);

            return numbers;
        }

        static List<int> ReadIntListSingleLine()
        { List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
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


    }
}
