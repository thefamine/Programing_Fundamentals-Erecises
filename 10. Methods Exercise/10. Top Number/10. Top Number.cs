using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                if (SumDigitsDivisibleBy8(i) && OneOddDigit(i))
                    Console.WriteLine(i);
            }
        }

        static bool SumDigitsDivisibleBy8(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                sum+= a % 10;
                a = a / 10;
            }
            if (sum % 8 == 0)
            { return true; }
            else
            { return false; }

        }

        static bool OneOddDigit(int a)
        {
            int counter = 0;
            while (a != 0)
            {
                int temp = a % 10;
                a = a / 10;
                if (temp % 2 != 0)
                { counter++; }
            }
            if (counter >= 1)
                return true;
            else
                return false;
        }
    }
}
