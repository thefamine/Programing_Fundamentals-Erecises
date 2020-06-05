/*1.	Sort Numbers
 Read three real numbers and sort them in descending order. 
 Print each number on a new line.

 */
 using System;

namespace _11._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          int a =  int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int first = Math.Max(a, Math.Max(b, c));
            int third = Math.Min(a, Math.Min(b, c));
            int second = (a + b + c - first - third);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}
