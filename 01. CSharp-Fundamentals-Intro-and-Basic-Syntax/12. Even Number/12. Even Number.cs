/*Take as an input an even number and print its absolute value. 
If the number is odd, print "Please write an even number." 
and continue reading numbers.*/
using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           int i = int.Parse(Console.ReadLine());
            while((i%2)!=0)
            {

                Console.WriteLine($"Please write an even number.");
                i = int.Parse(Console.ReadLine());
            }
            if (i < 0)
                i = i * -1;
            Console.WriteLine($"The number is: {i}");
        }
    }
}
