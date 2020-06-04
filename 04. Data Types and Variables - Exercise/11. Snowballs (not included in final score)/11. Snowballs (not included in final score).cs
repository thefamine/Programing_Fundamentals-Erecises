/*11.	*Snowballs
Tony and Andi love playing in the snow and having snowball fights, but they always argue which makes the best snowballs.
They have decided to involve you in their fray, by making you write a program, which calculates snowball data, 
and outputs the best snowball value.

You will receive N – an integer, the number of snowballs being made by Tony and Andi.
For each snowball you will receive 3 input lines:

•	On the first line you will get the snowballSnow – an integer.
•	On the second line you will get the snowballTime – an integer.
•	On the third line you will get the snowballQuality – an integer.
For each snowball you must calculate its snowballValue by the following formula:
(snowballSnow / snowballTime) ^ snowballQuality
At the end you must print the highest calculated snowballValue.

Input
•	On the first input line you will receive N – the number of snowballs.
•	On the next N * 3 input lines you will be receiving data about snowballs. 

Output
•	As output you must print the highest calculated snowballValue, by the formula, specified above. 
•	The output format is: 
{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})

Constraints
•	The number of snowballs (N) will be an integer in range [0, 100].
•	The snowballSnow is an integer in range [0, 1000].
•	The snowballTime is an integer in range [1, 500].
•	The snowballQuality is an integer in range [0, 100].
•	Allowed working time / memory: 100ms / 16MB.

 */
using System;
using System.Numerics;

namespace _11._Snowballs__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            byte N = byte.Parse(Console.ReadLine());
            short bestSnowballSnow = 0;
            short bestSnowballTime = 0;
            short bestSnowballQuality = 0;
            BigInteger bestSnowballValue = int.MinValue;
            for (int i = 0; i < N; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                short snowballQuality = short.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (bestSnowballValue <= snowballValue)
                {
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballValue = snowballValue;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");

        }
    }
}
