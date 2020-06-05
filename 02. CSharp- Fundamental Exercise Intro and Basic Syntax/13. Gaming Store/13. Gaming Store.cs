/*3.	Gaming Store
Write a program, which helps you buy the games. The valid games are the following games in this table:
Name	Price
OutFall 4	$39.99
CS: OG	$15.99
Zplinter Zell	$19.99
Honored 2	$59.99
RoverWatch	$29.99
RoverWatch Origins Edition	$39.99
On the first line, you will receive your current balance – a floating-point number in the range [0.00…5000.00].
Until you receive the command "Game Time", you have to keep buying games. When a game is bought, 
the user’s balance decreases by the price of the game.
Additionally, the program should obey the following conditions:
•	If a game the user is trying to buy is not present in the table above, print "Not Found" and
read the next line.
•	If at any point, the user has $0 left, print "Out of money! " and end the program.
•	Alternatively, if the user is trying to buy a game which they can’t afford, print "Too Expensive"
and read the next line"
•	If the game exists and the player has the money for it, print "Bought {nameOfGame}"
When you receive "Game Time", print the user’s remaining money and total spent on games, rounded to
the 2nd decimal place.

 */
using System;

namespace _13._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double startedMoney = currentBalance;
            string game = Console.ReadLine();
            bool flag = true;
            while (game != "Game Time")
            {
                if(currentBalance==0)
                { Console.WriteLine("Out of money!");break;flag = false; }

                if (game == "OutFall 4")
                { if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        { Console.WriteLine($"Bought {game}"); }
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (game == "CS: OG")
                {
                    if (currentBalance >= 15.99)
                    {
                        currentBalance -= 15.99;
                        { Console.WriteLine($"Bought {game}"); }
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (game == "Zplinter Zell")
                {
                    if (currentBalance >= 19.99)
                    {
                        currentBalance -= 19.99;
                        { Console.WriteLine($"Bought {game}"); }
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (game == "Honored 2")
                {
                    if (currentBalance >= 59.99)
                    {
                        currentBalance -= 59.99;
                        { Console.WriteLine($"Bought {game}"); }
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (game == "RoverWatch")
                {
                    if (currentBalance >= 29.99)
                    {
                        currentBalance -= 29.99;
                        { Console.WriteLine($"Bought {game}"); }
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        { Console.WriteLine($"Bought {game}"); }
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else
                { Console.WriteLine("Not Found"); }
                game = Console.ReadLine();

            }
            if (flag== true)
            {
                Console.WriteLine($"Total spent: ${startedMoney - currentBalance:F2}. Remaining: ${currentBalance:F2}");
            }
        }

    }
}
