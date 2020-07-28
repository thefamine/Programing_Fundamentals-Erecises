/*8.	Factorial Division
Read two integer numbers. Calculate factorial of each number. 
Divide the first result by the second and print the division formatted to the second decimal point.
*/
using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            decimal factorialA = FactorialDivision(a);
            decimal factorialB = FactorialDivision(b);
            Console.WriteLine($"{(factorialA/factorialB):F2}");
        }
        static decimal FactorialDivision(int a)
        { 
                decimal factorial = 1;
                for (int i = a; i > 0; i--)
                { factorial *= i; }
                return factorial;
            

        }

    }
}
