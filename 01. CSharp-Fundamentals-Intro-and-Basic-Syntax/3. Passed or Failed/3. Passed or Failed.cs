/* 3.	Passed or Failed
Modify the above program, so it will print "Failed!" if the grade is lower than 3.00.
Input
The input comes as a single double number.
Output
The output is either "Passed!" if the grade is more than 2.99, otherwise you
should print "Failed!".
*/
using System;

namespace _3._Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3)
                Console.WriteLine("Passed!");
            else
                Console.WriteLine("Failed!");
        }
    }
}
