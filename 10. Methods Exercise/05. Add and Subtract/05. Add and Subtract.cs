/*5.	Add and Subtract
You will receive 3 integers. Write a method Sum to get the sum of the first two integers and 
Subtract method that subtracts the third integer from the result from the Sum method. 
 */
using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
          
            Console.WriteLine(MathOperation(a, b, c));
        }
        static int MathOperation(int a, int b, int c)
        {
            a = a + b - c;
            return a;
        }
    }
}
