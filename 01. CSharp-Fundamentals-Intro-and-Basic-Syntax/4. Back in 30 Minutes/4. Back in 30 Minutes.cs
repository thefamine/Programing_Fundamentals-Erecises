/*4.	Back in 30 Minutes
Every time Stamat tries to pay his bills he sees on the cash desk the sign: 
 "I will be back in 30 minutes". One day Stamat was sick of waiting and decided
he needs a program, which prints the time after 30 minutes.That way he won’t 
have to wait on the desk and come at the appropriate time.He gave the assignment 
to you, so you have to do it.

Input
The input will be on two lines.On the first line, you will receive the hours and 
on the second you will receive the minutes. 

Output
Print on the console the time after 30 minutes.The result should be in format hh:mm.The hours have one or two numbers and the minutes have always two numbers (with leading zero).
Constraints
•	The hours will be between 0 and 23.
•	The minutes will be between 0 and 59.
*/
using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes>=60)
            {
                hours++;
                minutes -= 60;
            }
            if (hours>=24)
            { hours -= 24; }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
