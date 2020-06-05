/*1.	Train
You will be given a count of wagons in a train n. On the next n lines you will receive how many people are going to get on each wagon. 
At the end print the whole train and after that, on the next line, the sum of the people in the train. 

 */ using System;

namespace _07._Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] trainPeople = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {trainPeople[i] = int.Parse(Console.ReadLine());
             sum += trainPeople[i];
            }
            Console.WriteLine(string.Join(" ",trainPeople));
            Console.WriteLine($"{sum}");


        }
    }
}
