/*1.	 Valid Usernames
Write a program that reads user names on a single line (joined by ", ") and prints all valid usernames. 
A valid username is:
•	Has length between 3 and 16 characters
•	Contains only letters, numbers, hyphens and underscores
*/

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length >= 3 && input[i].Length <= 16)
                {
                    bool flag = true;
                    string username = input[i];
                    for (int j = 0; j < input[i].Length; j++)
                    {
                        /* if ((username[j] >= 65 && username[j] <= 90) ||
                             (username[j] >= 97 && username[j] <= 122) ||
                             (username[j] >= 48 && username[j] <= 57) ||
                             (username[j] == 45) ||
                                  (username[j] == 95))
                         { }
                         else
                         {
                             flag = false;
                             break;
                         }*/
                        if (!(char.IsLetterOrDigit(username[j])||username[j]=='-'|| username[j] == '_'))
                        {
                            flag = false;
                        }

                    }
                    if (flag == true)
                        Console.WriteLine(input[i]);
                }
            }
        }

        static List<int> ReadIntListSingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }

        static List<double> ReadDoubleListSingleLine()
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
            return list;
        }

        static List<string> ReadStringListSingleLine()
        {
            List<string> list = Console.ReadLine().Split().ToList();
            return list;
        }

        static void PrintIntListSingleLine(List<int> numbers, string a)
        { Console.WriteLine(string.Join(a, numbers)); }

        static void PrintDoubleListSingleLine(List<double> numbers, string a)
        { Console.WriteLine(string.Join(a, numbers)); }

        static void PrintStringListSingleLine(List<string> numbers, string a)
        { Console.WriteLine(string.Join(a, numbers)); }
    }
}
