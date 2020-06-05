/*3.	Vacation
You are given a group of people, type of the group, on which day of the week they are going to stay. 
Based on that information calculate how much they have to pay and print that price on the console. Use the table below. In each cell is the price for a single person. 
The output should look like that: "Total price: {price}". The price should be formatted to the second decimal point.
	      Friday	Saturday	Sunday
Students	8.45	9.80	10.46
Business	10.90	15.60	16
Regular	      15	20	    22.50
There are also discounts based on some conditions:
•	Students – if the group is bigger than or equal to 30 people you should reduce the total price by 15%
•	Business – if the group is bigger than or equal to  100 people 10 of them can stay for free.
•	Regular – if the group is bigger than or equal to 10 and less than or equal to 20 reduce the total price by 5%
You should reduce the prices in that EXACT order

 */
using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double money = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                    money = 8.45;
                else if (day == "Saturday")
                    money = 9.80;
                else if (day == "Sunday")
                    money = 10.46;
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                    money = 10.90;
                else if (day == "Saturday")
                    money = 15.60;
                else if (day == "Sunday")
                    money = 16.00;
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                    money = 15.0;
                else if (day == "Saturday")
                    money = 20;
                else if (day == "Sunday")
                    money = 22.50;
            }
            money *= amount * 1.0;
            if (type == "Students" && amount >= 30)
                money *= 0.85;
            if (type == "Business" && amount >= 100)
            {
                money /= amount;
                money *= (amount - 10);
            }
            if (type == "Regular" && amount >= 10&&amount<=20)
                money *= 0.95;
            Console.WriteLine($"Total price: {money:F2}");
        }
    }
}
