/*2.	Repeat Strings
Write a Program That Reads an Array of Strings. Each String is Repeated N Times, Where N is the Length of the String. 
Print the Concatenated String.
*/
using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                int count = word.Length;
                for(int i=0; i<count;i++)
                { result.Append(word); }
            }

            Console.WriteLine(result);
        }
    }
}
