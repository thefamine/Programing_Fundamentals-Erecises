/*You will be given 3 lines of input – student name, age and average grade. 
 * Your task is to print all the info about the student in the following format:
 * "Name: {student name}, 
 * Age: {student age}, Grade: {student grade}".*/
using System;

namespace _01._CSharp_Fundamentals_Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
        }
    }
}