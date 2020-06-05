/*1.	Convert Meters to Kilometers
You will be given an integer that will be distance in meters.Write a program that converts meters to 
kilometers formatted to the second decimal point.
*/
using System;

namespace _03._Data_Types_and_Variables___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0M;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
