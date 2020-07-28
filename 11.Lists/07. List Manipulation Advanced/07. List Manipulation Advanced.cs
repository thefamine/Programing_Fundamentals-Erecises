using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = ReadIntListSingleLine();
            string command;
            bool flag = true;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandSplit = command.Split().ToArray();
                switch (commandSplit[0])
                {
                    case "Add":
                        input.Add(int.Parse(commandSplit[1]));
                        flag = false;
                        break;

                    case "Remove":
                        input.Remove(int.Parse(commandSplit[1]));
                        flag = false;
                        break;

                    case "RemoveAt":
                        input.RemoveAt(int.Parse(commandSplit[1]));
                        flag = false;
                        break;

                    case "Insert":
                        input.Insert(int.Parse(commandSplit[2]), int.Parse(commandSplit[1]));
                        flag = false;
                        break;

                    case "Contains":
                        if (input.Contains(int.Parse(commandSplit[1])))
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No such number");
                        break;

                    case "PrintEven":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 0)
                            { Console.Write($"{input[i]} "); }
                        }
                        Console.WriteLine();
                        break;

                    case "PrintOdd":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] % 2 == 1)
                            { Console.Write($"{input[i]} "); }
                        }
                        Console.WriteLine();
                        break;

                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < input.Count; i++)
                        { sum += input[i]; }
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        for (int i = 0; i < input.Count; i++)
                        {
                            switch (commandSplit[1])
                            {
                                case "<":
                                    if (input[i] < int.Parse(commandSplit[2]))
                                    { Console.Write($"{input[i]} "); }
                                    break;
                                case ">":
                                    if (input[i] > int.Parse(commandSplit[2]))
                                    {
                                        Console.Write($"{input[i]} ");
                                    }
                                    break;
                                case "<=":
                                    if (input[i] <= int.Parse(commandSplit[2]))
                                    {
                                        Console.Write($"{input[i]} ");
                                    }
                                    break;
                                case ">=":
                                    if (input[i] >= int.Parse(commandSplit[2]))
                                    {
                                        Console.Write($"{input[i]} ");
                                    }
                                    break;
                            }
                        }
                        Console.WriteLine();
                        break;

                }

            }
            if (flag == true)
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
