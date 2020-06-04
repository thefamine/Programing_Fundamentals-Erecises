/*
2.	Print Numbers in Reverse Order
Read n numbers and print them in reverse order. 
*/
using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lines = int.Parse(Console.ReadLine());
            
            int[] numbers = new int[Lines];
            for (int i = 0; i < Lines; i++)
            { numbers[i] = int.Parse(Console.ReadLine()); }
          
            for (int i = 0; i <Lines; i++)
            { Console.Write($"{numbers[numbers.Length-i-1]} "); }
        }
    }
}