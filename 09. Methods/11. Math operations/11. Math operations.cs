/*Math Operations
Write a method that receives two number and an operator, 
calculates the result and returns it. You will be given three lines of input.
The first will be the first number, the second one will be the operator and the
last one will be the second number. The possible operators are: / * + -
Print the result rounded up to the second decimal point.

 */
using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal first = decimal.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            decimal second = decimal.Parse(Console.ReadLine());
            switch (operation)
            {
                case '*':
                    Console.WriteLine(Multiply2Digits(first,second));
                    break;
                case '/':
                    Console.WriteLine(Devide2Digits(first, second));
                    break;
                case '+':
                    Console.WriteLine(Add2Digits(first, second));
                    break;
                case '-':
                    Console.WriteLine(Subtrack2Digits(first, second));
                    break;
            }
        }

        static decimal Multiply2Digits(decimal first, decimal second)
        {
            decimal multiply = first * second;
            return multiply;
        }
        static decimal Devide2Digits(decimal first, decimal second)
        {
            decimal multiply = first / second;
            return multiply;
        }
        static decimal Add2Digits(decimal first, decimal second)
        {
            decimal multiply = first + second;
            return multiply;
        }
        static decimal Subtrack2Digits(decimal first, decimal second)
        {
            decimal multiply = first -second;
            return multiply;
        }

    }
}
