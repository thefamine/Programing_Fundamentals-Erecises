/*3.	Floating Equality
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant eps. 
You will receive two lines, each containing a floating-point number. Your task is to compare the values of the two numbers.

 */
using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();


            string intA = a.Substring(0, a.IndexOf("."));
            string intB = b.Substring(0, b.IndexOf("."));

            int realIntA = int.Parse(intA);
            int realIntB = int.Parse(intB);
            int maxInt = Math.Max(realIntA, realIntB);

            double doubleA = double.Parse(a) - maxInt;
            double doubleB = double.Parse(b) - maxInt;

            bool precision = false;
            if (Math.Abs(doubleA - doubleB) <= 0.000001)
            {precision = true;}

            Console.WriteLine(precision);

          
        }
    }
}
