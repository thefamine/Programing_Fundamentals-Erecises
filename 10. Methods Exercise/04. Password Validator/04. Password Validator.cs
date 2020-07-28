/*4.	Password Validator
Write a program that checks if a given password is valid. Password rules are:
•	6 – 10 characters (inclusive)
•	Consists only of letters and digits
•	Have at least 2 digits 
If a password is valid print "Password is valid". If it is not valid, for every unfulfilled rule print a message:
•	"Password must be between 6 and 10 characters"
•	"Password must consist only of letters and digits"
•	"Password must have at least 2 digits"
*/
using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }
        static void ValidatePassword(string text)
        {
            bool invalid = false;

            if (text.Length > 10 || text.Length < 6)
            { Console.WriteLine("Password must be between 6 and 10 characters ");
                invalid = true;
            }

            if (CheckIfContainsOnlyDigitsAndLetters(text) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }
            if (ContentAtleastTwoDigits(text)<2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }

            if (invalid == false)
            { Console.WriteLine("Password is valid"); }

        }

        static bool CheckIfContainsOnlyDigitsAndLetters(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!((text[i] >= 48 && text[i] <= 57) ||
                   (text[i] >= 65 && text[i] <= 90) ||
                   (text[i] >= 97 && text[i] <= 122)))
                { return false; }

            }
            return true;
        }
        
        static int ContentAtleastTwoDigits(string text)
        {
            int digitCounter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= 48 && text[i] <= 57))
                { digitCounter++; }

            }
            return digitCounter;
        }
    }
}
