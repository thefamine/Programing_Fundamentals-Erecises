/*3.	Zig-Zag Arrays
Write a program which creates 2 arrays. You will be given an integer n. 
On the next n lines you get 2 integers. Form 2 arrays as shown below.
*/
using System;
using System.Linq;
namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstLine = new int[n];
            int[] SecondLine = new int[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                bool flag = false;
                if (i % 2 == 0)
                {
                    firstLine[i] = input[0];
                    SecondLine[i] = input[1];
                }
                else
                {
                    firstLine[i] = input[1];
                    SecondLine[i] = input[0];
                }
            }

            Console.WriteLine(String.Join(" ", firstLine));
            Console.WriteLine(String.Join(" ", SecondLine));
        }
    }
}
