/*9.	Greater of Two Values
Create a method GetMax() that returns the greater of two values 
(the values can be of type int, char or string)
*/
using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second =Console.ReadLine();
                Console.WriteLine(GetBigger(first, second));
            }




        }

        static int GetBigger(int a, int b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            { return a; }
            else
            { return b; }
        }
        static string GetBigger(string a, string b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            { return a; }
            else
            { return b; }
        }
        static char GetBigger(char a, char b)
        {
            int compare = a.CompareTo(b);
            if (compare > 0)
            { return a; }
            else
            { return b; }
        }



    }
}

