/*2.	Center Point
You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2. 
Create a method that prints the point that is closest to the center of the coordinate system (0, 0) 
in the format (X, Y). If the points are on a same distance from the center, print only the first one.
*/
using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double radius1 = Math.Pow((X1 * X1 + Y1 * Y1), 0.5);
            double radius2 = Math.Pow((X2 * X2 + Y2 * Y2), 0.5);
            if (radius1 <= radius2)
            { Console.WriteLine($"({X1}, {Y1})"); }
            else
            { Console.WriteLine($"({X2}, {Y2})"); }
        }
    }
}
