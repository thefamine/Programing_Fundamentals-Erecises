/*11.	Multiplication Table 2.0
Rewrite you program so it can receive the multiplier from the console. 
Print the table from the given multiplier to 10. If the given multiplier 
is more than 10 - print only one row with the integer, the given multiplier and 
the product. See the examples below for more information.
Output
Print every row of the table in the following format:
{theInteger} X {times} = {product}
Constraints
•	The integer will be in the interval [1…100]
*/
using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int i= int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
                i++;
            } while (i <= 10);
        }
    }
}