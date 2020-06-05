/*7.	Vending Machine
You task is to calculate the total price of a purchase from a vending machine. 
Until you receive "Start" you will be given different coins that are being inserted in the machine. 
You have to sum them in order to have the total money inserted. 
There is a problem though. Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins. 
If someone tries to insert some other coins you have to display "Cannot accept {money}" and not add it to the total money.
On the next few lines until you receive "End" you will be given products to purchase. 
Your machine has however only "Nuts", "Water", "Crisps", "Soda", "Coke". The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively.
If the person tries to purchase a not existing product print "Invalid product". 
Be careful that the person may try to purchase a product they don’t have the money for.
In that case print "Sorry, not enough money". If the person purchases a product successfully print "Purchased {product name}". 
After the "End" command print the money that are left formatted to the second decimal point in the format "Change: {money left}".

*/
using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = "1";
            double total = 0;
            string product = string.Empty;

            while (coins != "Start")
            {
                coins = Console.ReadLine();
                if (coins == "Start")
                { break; }
                double money = double.Parse(coins);
                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1.0 || money == 2.1)
                { total += money; }
                else
                    Console.WriteLine($"Cannot accept {money}");
            }
            product = Console.ReadLine();
            while (product != "End")
            {
              
                if (product == "Nuts")
                    if (total >= 2.0)
                    {Console.WriteLine($"Purchased nuts");
                        total -= 2.0;}
                    else
                    {Console.WriteLine("Sorry, not enough money");}
                else if (product == "Water")
                    if (total >= 0.7)
                    {Console.WriteLine($"Purchased water");
                        total -= 0.7;}
                    else
                    {Console.WriteLine("Sorry, not enough money");}
                else if (product == "Crisps")
                    if (total >= 1.5)
                    {Console.WriteLine($"Purchased crisps");
                        total -= 1.5;}
                    else
                    {Console.WriteLine("Sorry, not enough money");}
                else if (product == "Soda")
                    if (total >= 0.8)
                    {Console.WriteLine($"Purchased soda");
                        total -= 0.8;}
                    else
                    {Console.WriteLine("Sorry, not enough money");}
                else if (product == "Coke")
                    if (total >= 1.0)
                    {Console.WriteLine($"Purchased coke");
                        total -= 1.0;}
                    else
                    {Console.WriteLine("Sorry, not enough money");}
                else 
                    Console.WriteLine("Invalid product");
                product = Console.ReadLine();

            }
            Console.WriteLine($"Change: {total:F2}");

        }
    }
}
