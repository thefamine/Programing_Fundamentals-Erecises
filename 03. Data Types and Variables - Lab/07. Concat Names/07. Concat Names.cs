/*7.	Concat Names
Read two names and a delimiter. 
Print the names joined by the delimiter.
 */
using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string result = firstName + delimiter + lastName;
            Console.WriteLine(result);
        }

    }
}

