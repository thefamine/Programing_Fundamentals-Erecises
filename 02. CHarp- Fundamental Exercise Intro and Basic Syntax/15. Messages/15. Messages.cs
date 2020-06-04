/*Write a program, which emulates typing an SMS, following this guide:
1	2   3
   abc	Def
4   5    6  
ghi	jkl	Mno
7    8    9
pqrs tuv Wxyz
	 0
   space	
Following the guide, 2 becomes "a", 22 becomes "b" and so on.
Hints
•	A native approach would be to just put all the possible combinations of digits in a giant 
switch
statement.
•	A cleverer approach would be to come up with a mathematical formula, which converts a number
to 
its alphabet representation:
•	Let’s take the number 222 (c) for example. Our algorithm would look like this:
o	Find the number of digits the number has "e.g. 222  3 digits"
o	Find the main digit of the number "e.g.  222  2"
o	Find the offset of the number. To do that, you can use the formula: (main digit - 2) * 3
o	If the main digit is 8 or 9, we need to add 1 to the offset, since the digits 7 and 9 have 4 
letters each
o	Finally, find the letter index (a  0, c  2, etc.). To do that, we can use the following
formula: (offset + digit length - 1).
o	After we’ve found the letter index, we can just add that to the ASCII code of the lowercase
letter "a" (97)

 */
using System;

namespace _15._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = "";
            for (int i = 1; i <= number; i++)
            {
                int code = int.Parse(Console.ReadLine());
                int numberOfDigits = code.ToString().Length;
                int mainDigit = code % 10;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                { offset++; }

                if (code == 0)
                { text += " "; continue; }
                int letterIndex = (offset + numberOfDigits - 1);
                int letter = 97 + letterIndex;
                text += (char)letter;
            }
            Console.Write(text);

        }
    }
}

