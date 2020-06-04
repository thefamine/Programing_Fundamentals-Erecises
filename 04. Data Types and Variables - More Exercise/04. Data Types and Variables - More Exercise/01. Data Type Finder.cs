﻿using System;

namespace _04._Data_Types_and_Variables___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input != "End")
            {
                bool intTryParseIsSucceess = int.TryParse(input, out int intValue);
                bool doubleTryParseIsSuccess = double.TryParse(input, out double doubleValue);
                bool charTryParseIsSuccess = char.TryParse(input, out char charValue);
                bool boolTryParseIsSuccess = bool.TryParse(input, out bool boolValue);

                if (intTryParseIsSucceess)
                    Console.WriteLine($"{input} is integer type");
                else if (doubleTryParseIsSuccess)
                    Console.WriteLine($"{input} is floating point type");
                else if (boolTryParseIsSuccess)
                    Console.WriteLine($"{input} is boolean type");
                else if (charTryParseIsSuccess)
                    Console.WriteLine($"{input} is character type");
                else
                    Console.WriteLine($"{input} is string type");

                input = Console.ReadLine();
            }
        }
    }
}