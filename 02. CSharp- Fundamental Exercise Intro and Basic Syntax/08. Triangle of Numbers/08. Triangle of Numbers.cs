/*8.Triangle of Numbers
Write a program, which receives a number – n, and prints a triangle from 1 to n as in the examples.
Constraints
•	n will be in the interval [1...20].
*/
using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          int n =int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 1; i <= n; i++)
            {
               
               for(int j=1;j <= number; j++)
                {
                    Console.Write($"{number} ");
                }

                Console.WriteLine();
                number++;
            }
        }
    }
}
