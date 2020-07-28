/*6.	Middle Characters
You will receive a single string. Write a method that prints the middle character. 
If the length of the string is even there are two middle characters.
*/
using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            returnMiddleChar(input);


        }

        static void returnMiddleChar(string input)
        {
            char[] chars = new char[2];
            if (input.Length % 2 == 0)
            {
                chars[0] = (char)input[input.Length / 2 - 1];
                chars[1] = (char)input[input.Length / 2];
            }

            else
            {
                chars[0] = (char)input[input.Length / 2];
            }
            Console.WriteLine(string.Join("",chars));
    
        }
    }
}
