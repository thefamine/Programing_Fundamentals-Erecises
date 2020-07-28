/*5.	Digits, Letters and Other
Write a program that receives a single string and on the first line prints all the digits, 
on the second – all the letters, and on the third – all the other characters. There will always
be at least one digit, one letter and one other characters.
 */
using System;
using System.Text;
namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Append(input[i]);
                }
                if (char.IsLetter(input[i]))
                {
                    letters.Append(input[i]);
                }
                if (!char.IsLetter(input[i])&&!char.IsDigit(input[i]))
                {
                    others.Append(input[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
