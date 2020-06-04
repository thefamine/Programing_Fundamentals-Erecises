/*10.Multiplication Table
You will receive an integer as an input from the console. 
Print the 10 times table for this integer. 
See the examples below for more information.

Output
Print every row of the table in the following format:
{theInteger} X {times} = {product}

Constraints
•	The integer will be in the interval [1…100]
*/
using System;

namespace _10.__Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");
                i++;
            }
        }
    }
}
