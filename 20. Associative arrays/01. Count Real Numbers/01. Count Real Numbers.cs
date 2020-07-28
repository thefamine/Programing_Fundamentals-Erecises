using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> inputDict = new SortedDictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!inputDict.ContainsKey(input[i]))
                { inputDict.Add(input[i], 1); }
                else
                {
                   inputDict[input[i]]++;
                }
            }

            foreach (var item in inputDict)
            { 
                Console.WriteLine(item.Key+" -> "+item.Value); 
            }

        }
    }
}
