/*4.	Reverse String
Write a program which reverses a string and print it on the console.
 */

using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = String.Empty;
            
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            Console.WriteLine(password);

        }
    }
}
