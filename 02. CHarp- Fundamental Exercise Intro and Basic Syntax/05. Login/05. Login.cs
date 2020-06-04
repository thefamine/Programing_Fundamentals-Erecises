/*5.	Login
You will be given a string representing a username. The password will be that username reversed. Until you receive the correct password print on the console "Incorrect password. 
Try again. ". When you receive the correct password print "User {username} logged in.
" However on the fourth try if the password is still not correct print "User {username} blocked! "
and end the program.
*/
using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password= String.Empty;
            string access = String.Empty;

            for (int i=username.Length-1;i>=0;i--)
            {
                password += username[i];
            }
            access = Console.ReadLine();
            int counter = 1;
            while (password != access)
            {
                Console.WriteLine($"Incorrect password. Try again.");
                access = Console.ReadLine();
                counter++;
                if (counter == 4)
                { break; }
            }
            if(access==password)
            Console.WriteLine($"User {username} logged in.");
            else
            Console.WriteLine($"User {username} blocked!");

        }
    }
}
