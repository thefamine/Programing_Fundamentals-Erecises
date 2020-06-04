/*10.	Lower or Upper
Write a program that prints whether a given character is upper-case or lower case.*/

using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            int CharNum = (int)a;
            string caseType = String.Empty;
            if ((CharNum >= 97) && (CharNum <= 122))
            { caseType = "lower"; }
            else if ((CharNum >= 65) && (CharNum <= 90))
            { caseType = "upper"; }

            Console.WriteLine($"{caseType}-case");
        }
    }
}
