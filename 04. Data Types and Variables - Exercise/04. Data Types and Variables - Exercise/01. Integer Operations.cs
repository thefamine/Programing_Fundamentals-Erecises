/*1.	Integer Operations
Read four integer numbers. Add first to the second, divide (integer) the sum by the third number and multiply 
the result by the fourth number. Print the result.

Constraints 
•	First number will be in the range [-2,147,483,648… 2,147,483,647]
•	Second number will be in the range [-2,147,483,648… 2,147,483,647]
•	Third number will be in the range [-2,147,483,648… 2,147,483,647]
•	Fourth number will be in the range [-2,147,483,648… 2,147,483,647] 
 */
using System;

namespace _04._Data_Types_and_Variables___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber  = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int ThirdNumber  = int.Parse(Console.ReadLine());
            int FourthNumber = int.Parse(Console.ReadLine());

            int Output = (FirstNumber + SecondNumber) / ThirdNumber * FourthNumber;
            Console.WriteLine(Output);
        }
    }
}
