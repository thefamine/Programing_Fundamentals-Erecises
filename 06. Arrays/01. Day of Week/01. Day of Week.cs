/*1.	Day of Week
Enter a day number [1…7] and print the name (in English) or "Invalid day!"
 */
using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] weekDays = new string[7]
            {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

            if (input >= 1 && input <= 7)
            { Console.WriteLine(weekDays[input-1]);}
            else
              Console.WriteLine($"Invalid day!");
   

        }
    }
}
