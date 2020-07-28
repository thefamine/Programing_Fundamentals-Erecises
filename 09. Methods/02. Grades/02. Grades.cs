/*2.	Grades
Write a method that receives a grade between 2.00 and 6.00 and prints the 
corresponding grade in words
•	2.00 – 2.99 - "Fail"
•	3.00 – 3.49 - "Poor"
•	3.50 – 4.49 - "Good"
•	4.50 – 5.49 - "Very good"
•	5.50 – 6.00 - "Excellent"

 */
using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Grades(input);
           
        }
        static void Grades(double a)
        {
            if (a >= 2.00 && a <= 2.99)
                Console.WriteLine("Fail");
            else if (a >= 3.00 && a <= 3.49)
                Console.WriteLine("Poor");
            else if (a >= 3.50 && a <= 4.49)
                Console.WriteLine("Good");
            else if (a >= 4.50 && a <= 5.49)
                Console.WriteLine("Very good");
            else if (a >= 5.50 && a <= 6.00)
                Console.WriteLine("Excellent");
        }
    }
}
