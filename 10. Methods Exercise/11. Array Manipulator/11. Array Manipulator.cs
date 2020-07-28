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

namespace _11._Array_Manipulator
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
   
                if (command[0] == "max" && command[1] == "even")
                { Console.WriteLine(MaxEven(input)); }

                else if (command[0] == "min" && command[1] == "even")
                { Console.WriteLine(MinEven(input)); }

                else if (command[0] == "max" && command[1] == "odd")
                { Console.WriteLine(MaxOdd(input)); }

                else if (command[0] == "min" && command[1] == "odd")
                { Console.WriteLine(MinOdd(input)); }

                else if (command[0] == "exchange")
                { Exchange(ref input, int.Parse(command[1])); }

                else if (command[0] == "first" && command[2] == "even")
                { Console.WriteLine($"[{String.Join(", ",FirstNEven(input,int.Parse(command[1])))}]"); }

                else if (command[0] == "first" && command[2] == "odd")
                { Console.WriteLine($"[{String.Join(", ", FirstNOdd(input, int.Parse(command[1])))}]"); }

                else if (command[0] == "last" && command[2] == "even")
                { Console.WriteLine($"[{String.Join(", ", LastNEven(input, int.Parse(command[1])))}]"); }

                else if (command[0] == "last" && command[2] == "odd")
                { Console.WriteLine($"[{String.Join(", ", LastNOdd(input, int.Parse(command[1])))}]"); }


            }
            Console.WriteLine(String.Join(' ', input));


        }

        static int[] FirstNEven(int[] a, int index)
        {
            int[] firstNNumbers = new int[index];
            int counter = 0;
            for (int i = 0; i <a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    firstNNumbers[counter] = a[i];
                    counter++;
                }
                if (counter == index)
                { break; }
            }

            return firstNNumbers;
        }
        static int[] FirstNOdd(int[] a, int index)
        {
            int[] firstNNumbers = new int[index];
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    firstNNumbers[counter] = a[i];
                    counter++;
                }
                if (counter == index)
                { break; }
            }

            return firstNNumbers;
        }
        static int[] LastNEven(int[] a, int index)
        {
          int[] lastNNumbers = new int[index];
           /* int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    lastNNumbers[counter] = a[i];
                    counter++;
                }
                if (counter == index)
                { break; }
            }*/
            
            return lastNNumbers;
        }
        static int[] LastNOdd(int[] a, int index)
        {
            int[] lastNNumbers = new int[index];
           /* int counter = 0;
            for (int i = a.Length; i > 0; i--)
            {
                if (a[i] % 2 != 0)
                {
                    lastNNumbers[counter] = a[i];
                    counter++;
                }
                if (counter == index)
                { break; }
            }
            */
            return lastNNumbers;
        }


        static void Exchange(ref int[] a, int index)
        {

            int[] firstArray = new int[a.Length - index];
            for (int i = 0; i < firstArray.Length; i++)
            { firstArray[i] = a[i]; }

            int[] secondArray = new int[index];
            for (int i = 0; i < secondArray.Length; i++)
            { secondArray[i] = a[index + i+1]; }

            for (int i = 0; i < secondArray.Length; i++)
            {
                a[i] = secondArray[i];
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                 a[i + index] = firstArray[i];
            }
        }
        static string MaxEven(int[] a)
        {
            int MaxEven = int.MinValue;
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] >= MaxEven) && (a[i] % 2 == 0))
                {
                    MaxEven = a[i];
                    counter = i;
                }
            }
            string Output;
            if (MaxEven == int.MinValue)
            { Output = "No matches"; }
            else
            { Output = counter.ToString(); }
            return Output;
        }
        static string MaxOdd(int[] a)
        {
            int MaxOdd = int.MinValue;
            int counter = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] >= MaxOdd) && (a[i] % 2 != 0))
                {
                    MaxOdd = a[i];
                    counter = i;
                }
            }
            string Output;
            if (MaxOdd == int.MinValue)
            { Output = "No matches"; }
            else
            { Output = counter.ToString(); }
            return Output;
        }
        static string MinEven(int[] a)
        {
            int MinEven = int.MaxValue;
            int counter = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] <= MinEven) && (a[i] % 2 == 0))
                {
                    MinEven = a[i];
                    counter = i;
                }
            }
            string Output;
            if (MinEven == int.MaxValue)
            { Output = "No matches"; }
            else
            { Output = counter.ToString(); }
            return Output;
        }
        static string MinOdd(int[] a)
        {
            int MinOdd = int.MaxValue;
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] <= MinOdd) && (a[i] % 2 != 0))
                {
                    MinOdd = a[i];
                    counter = i;
                }
            }
            string Output;
            if (MinOdd == int.MaxValue)
            { Output = "No matches"; }
            else
            { Output = counter.ToString(); }
            return Output;
        }



    }
}
