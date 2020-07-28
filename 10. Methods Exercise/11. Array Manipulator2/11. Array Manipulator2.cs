/*11.	*Array Manipulator
Trifon has finally become a junior developer and has received his first task. It’s about manipulating an array of 
integers. He is not quite happy about it, since he hates manipulating arrays. They are going to pay him a lot of
money, though, and he is willing to give somebody half of it if to help him do his job. You, on the other hand,
love arrays (and money) so you decide to try your luck.

The array may be manipulated by one of the following commands
•	exchange {index} – splits the array after the given index, and exchanges the places of the two resulting 
sub-arrays. E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
o	If the index is outside the boundaries of the array, print "Invalid index"
•	max even/odd– returns the INDEX of the max even/odd element -> [1, 4, 8, 2, 3] -> max odd -> print 4
•	min even/odd – returns the INDEX of the min even/odd element -> [1, 4, 8, 2, 3] -> min even > print 3
o	If there are two or more equal min/max elements, return the index of the rightmost one
o	If a min/max even/odd element cannot be found, print "No matches"
•	first {count} even/odd– returns the first {count} elements -> [1, 8, 2, 3] -> first 2 even -> print [8, 2]
•	last {count} even/odd – returns the last {count} elements -> [1, 8, 2, 3] -> last 2 odd -> print [1, 3]
o	If the count is greater than the array length, print "Invalid count"
o	If there are not enough elements to satisfy the count, print as many as you can. If there are zero even/odd
elements, print an empty array " []"
•	end – stop taking input and print the final state of the array

Input
•	The input data should be read from the console.
•	On the first line, the initial array is received as a line of integers, separated by a single space
•	On the next lines, until the command "end" is received, you will receive the array manipulation commands
•	The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
•	The output should be printed on the console.
•	On a separate line, print the output of the corresponding command
•	On the last line, print the final array in square brackets with its elements separated by 
a comma and a space 
•	See the examples below to get a better understanding of your task

Constraints
•	The number of input lines will be in the range [2 … 50].
•	The array elements will be integers in the range [0 … 1000].
•	The number of elements will be in the range [1 .. 50]
•	The split index will be an integer in the range [-231 … 231 – 1]
•	first/last count will be an integer in the range [1 … 231 – 1]
•	There will not be redundant whitespace anywhere in the input
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
*/

using System;
using System.Linq;

namespace _11._Array_Manipulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            string manipulations;

            while ((manipulations = Console.ReadLine()) != "end")
            {
                string[] command = manipulations.Split();

                if (command[0] == "min" || command[0] == "max")
                { Console.WriteLine(MinMaxEvenOdd(input, command[0], command[1])); }

                else if (command[0] == "first" || command[0] == "last")
                {
                    if (int.Parse(command[1]) > input.Length)
                        Console.WriteLine("Invalid count");
                    else
                    { FirstLastNEvenOdd(input, command[0], int.Parse(command[1]), command[2]); }
                }
                else if (command[0] == "exchange")
                {
                    if (int.Parse(command[1]) > input.Length)
                        Console.WriteLine("Invalid index");
                    else
                        Exchange(ref input, int.Parse(command[1]));
                }

            }
            Console.WriteLine($"[{String.Join(", ", input)}]");


        }

        static string MinMaxEvenOdd(int[] input, string MinMax, string EvenOdd)
        {
            int counter = 0;

            int MaxMinValue = int.MinValue;
            if (MinMax == "min")
            { MaxMinValue = int.MaxValue; }

            int EvOd = 0;

            if (EvenOdd == "odd")
            { EvOd = 1; }

            for (int i = 0; i < input.Length; i++)
            {
                if (((MinMax == "max") && (input[i] >= MaxMinValue) && (input[i] % 2 == EvOd)) ||
                    ((MinMax == "min") && (input[i] <= MaxMinValue) && (input[i] % 2 == EvOd)))
                {
                    MaxMinValue = input[i];
                    counter = i;
                }
            }

            string Output;
            if (MaxMinValue == int.MinValue || MaxMinValue == int.MaxValue)
            { Output = "No matches"; }
            else
            { Output = counter.ToString(); }
            return Output;
        }

        static void FirstLastNEvenOdd(int[] input, string firstLast, int n, string EvenOdd)
        {
            int EvOd = 0;
            if (EvenOdd == "odd")
            { EvOd = 1; }

            int[] NNumbers = new int[n];

            int counter = 0;
            if (firstLast == "first")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == EvOd)
                    {
                        NNumbers[counter] = input[i];
                        counter++;
                    }
                    if (counter == n)
                    { break; }
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[input.Length-1-i] % 2 == EvOd)
                    {
                        NNumbers[NNumbers.Length-1-counter] = input[input.Length-1-i];
                        counter++;
                    }
                    if (counter == n )
                    { break; }
                }
            }


            if(counter==0)
                Console.WriteLine("[]");
            else
            Console.WriteLine($"[{String.Join(", ", NNumbers)}]");
        }



        static void Exchange(ref int[] input, int index)
        {
            int[] firstArray = new int[index+1];
            for (int i = 0; i < firstArray.Length; i++)
            { firstArray[i] = input[i]; }

            int[] secondArray = new int[input.Length-firstArray.Length];
            for (int i = 0; i < secondArray.Length; i++)
            { secondArray[i] = input[firstArray.Length+i]; }
       
            for (int i = 0; i < secondArray.Length; i++)
            { input[i] = secondArray[i]; }
            for (int i = 0; i < firstArray.Length; i++)
            { input[secondArray.Length+i] = firstArray[i]; }
        }

    }
}