﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = ReadIntListSingleLine();
            string command;
            while ((command=Console.ReadLine()) != "end")
            {
                string[] commandSplit= command.Split().ToArray();
                switch (commandSplit[0])
                {
                    case "Add":
                        input.Add(int.Parse(commandSplit[1]));
                        break;
                    case "Remove":
                        input.Remove(int.Parse(commandSplit[1]));
                        break;
                    case "RemoveAt":
                        input.RemoveAt(int.Parse(commandSplit[1]));
                        break;
                    case "Insert":
                        input.Insert(int.Parse(commandSplit[2]),int.Parse(commandSplit[1]));
                        break;
                }

            }

            PrintIntListSingleLine(input, " ");
        }


        static void RemoveNegativeValFromIntList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < 0)
                {
                    input.RemoveRange(i, 1);
                    if (i > 1)
                        i -= 2;
                    else
                        i = -1;
                }
            }

        }

        static List<int> MergingLists(List<int> firstList, List<int> secondList)
        {
            int minLen = Math.Min(firstList.Count, secondList.Count);
            List<int> result = new List<int>();
            for (int i = 0; i < minLen * 2; i++)
            {
                if (i % 2 == 0)
                { result.Add(firstList[i / 2]); }
                else
                { result.Add(secondList[i / 2]); }

            }
            for (int i = minLen; i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (secondList.Count > firstList.Count)
                { result.Add(secondList[i]); }
                else
                { result.Add(firstList[i]); }
            }
            return result;
        }

        static List<int> SumAdjacentEqualNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1 - i];
            }
            if (numbers.Count % 2 == 1)
                numbers.RemoveRange(numbers.Count / 2 + 1, numbers.Count / 2);
            else
                numbers.RemoveRange(numbers.Count / 2, numbers.Count / 2);

            return numbers;
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