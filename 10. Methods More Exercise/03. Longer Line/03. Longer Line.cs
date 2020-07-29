/*3.	Longer Line
You are given the coordinates of four points in the 2D plane.The first and the second pair of points form two different 
lines.Print the longer line in format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center of the 
coordinate system (0, 0) (You can reuse the method that you wrote for the previous problem).
If the lines are of equal length, print only the first one.
*/
using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());


            double lineLenght1 = LineLenght(X1, Y1, X2, Y2);
            double lineLenght2 = LineLenght(X3, Y3, X4, Y4);

            if (lineLenght1 > lineLenght2)
            { Console.WriteLine(CenterPoint(X1, Y1, X2, Y2)); }
            else
            { Console.WriteLine(CenterPoint(X3, Y3, X4, Y4)); }


        }
        static string CenterPoint(double X1, double Y1, double X2, double Y2)
        {
            string output;
            double radius1 = Math.Pow((X1 * X1 + Y1 * Y1), 0.5);
            double radius2 = Math.Pow((X2 * X2 + Y2 * Y2), 0.5);
            if (radius1 <= radius2)
                output = "(" + X1 + ", " + Y1 + ")"+ "(" + X2 + ", " + Y2 + ")";
            else
                output = "(" + X2 + ", " + Y2 + ")"+ "(" + X1 + ", " + Y1 + ")";
            return output;

        }
        static double LineLenght(double X1, double Y1, double X2, double Y2)
        {
            double X = X2 - X1;
            double Y = Y2 - Y1;
            double output = Math.Pow((X * X + Y * Y),0.5);
            return output;
        }

    }
}
