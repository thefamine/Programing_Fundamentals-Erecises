/*12.	Refactor Special Numbers
You are given a working code that is a solution to Problem 5. Special Numbers. However, 
the variables are improperly named, declared before they are needed and some of them are used for multiple things. 
Without using your previous solution, modify the code so that it is easy to read and understand.
*/
/*5.	Special Numbers
A number is special when its sum of digits is 5, 7 or 11.
Write a program to read an integer n and for all numbers in the range 1…n to print the number and if
it is special or not (True / False).
*/
using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool IsTrue = false;

            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;
                while (digits > 0)
                {sumOfDigits += digits % 10;
                 digits = digits / 10;}
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {IsTrue = true;}
                Console.WriteLine($"{num} -> {IsTrue}");
                IsTrue = false;
            }

        }
    }
}


