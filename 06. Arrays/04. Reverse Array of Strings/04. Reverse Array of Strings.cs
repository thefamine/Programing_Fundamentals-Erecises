/*4.	Reverse Array of Strings
Read an array of strings (space separated values), reverse it and print its elements:
*/
using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
       
            for (int i = 0; i < input.Length/2; i++)
            {
                var temp = input[i];
                input[i]= input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
