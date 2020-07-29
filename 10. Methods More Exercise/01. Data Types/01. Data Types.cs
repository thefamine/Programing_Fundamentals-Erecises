/*1.	Data Types
Write a program that, depending on the first line of the input, reads an int, double or string.
•	If the data type is int, multiply the number by 2.
•	If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
•	If the data type is string, surround the input with "$".
Print the result on the console.*/

using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string secondinput = Console.ReadLine();
           if(input=="real")
            Console.WriteLine($"{double.Parse(DataTypes(input, secondinput)):F2}");
           else
            Console.WriteLine(DataTypes(input, secondinput));

        }
        static string DataTypes(string type, string value)
        {
            string output = string.Empty;
            switch (type)
            {
                case "int":
                    output = (int.Parse(value) * 2).ToString();
                    break;
                case "real":
                    output = (double.Parse(value) * 1.5).ToString();
                    break;
                case "string":
                    output = "$" + value + "$";
                    break;
            }
            return output;

        }
    }
}

