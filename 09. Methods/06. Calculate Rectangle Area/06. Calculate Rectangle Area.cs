﻿/*6.	Calculate Rectangle Area
Create a method that calculates and returns the area of a rectangle by given 
width and height: */
using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = RectangleArea(width, height);
            Console.WriteLine(area);
            
        }
        static double RectangleArea(double width, double height)
        { return width * height; }


    }
}
