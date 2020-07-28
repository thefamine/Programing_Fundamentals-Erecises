/*7.	Repeat String
Write a method that receives a string and a repeat count n (integer). 
The method should return a new string (the old one repeated n times)
 */ 
 using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplyString(name,count));
        }

        static string MultiplyString(string str, int count)
        {
            string a = "";
            for (int i = 0; i < count; i++)
            {
                a += str;
            }
            return a;
        }
    }
}
