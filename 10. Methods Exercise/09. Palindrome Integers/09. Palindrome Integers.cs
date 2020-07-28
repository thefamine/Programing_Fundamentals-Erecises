using System;
using System.Linq;
namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputS = Console.ReadLine();

            while (inputS != "END")
            {
                
                if (PalidromeIntegers(inputS))
                { Console.WriteLine($"true"); }
                else
                { Console.WriteLine($"false"); }

                inputS = Console.ReadLine();
            }


        }

        static bool PalidromeIntegers(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a[a.Length- i-1])
                { return false; }
            }
            return true;
        }

    }
}
