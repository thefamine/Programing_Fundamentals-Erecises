using System;
using System.Linq;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandsSplit = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (commandsSplit[0])
                {
                    case "TakeOdd":
                        TakeOdd(password);
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        break;
                    case "Substitute":
                        break;
                }
            }

        }
        static void TakeOdd(string password)
        {
            password=password.Select()
        }

    }
}
