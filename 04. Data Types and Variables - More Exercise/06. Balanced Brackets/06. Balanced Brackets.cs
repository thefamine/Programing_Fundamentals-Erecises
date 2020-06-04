/*6.	Balanced Brackets
You will receive n lines. On those lines, you will receive one of the following:
•	Opening bracket – “(“,
•	Closing bracket – “)” or
•	Random string
Your task is to find out if the brackets are balanced. That means after every closing bracket should follow an opening one. 
Nested parentheses are not valid, and if two consecutive opening brackets exist, the expression should be marked as unbalanced. 

Input
•	On the first line, you will receive n – the number of lines, which will follow
•	On the next n lines, you will receive "(”, “)" or another string
Output
You have to print "BALANCED", if the parentheses are balanced and "UNBALANCED" otherwise.
Constraints
•	n will be in the interval [1…20]
•	The length of the stings will be between [1…100] characters

 */
using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string Brackets = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string Random = Console.ReadLine();
                if (Random.Length <= 3)
                {
                    string shortRandom = Random.Substring(0, 1);
                    char a = char.Parse(shortRandom);

                    if (a == '(' || a == ')')
                    {
                        Brackets += a;
                    }
                }
            }

            bool isBalanced = true;


            if (Brackets[0] == ')')
                isBalanced = false;

            if (Brackets.Length%2 != 0)
               isBalanced = false;

            if (isBalanced)
            {
                for (int i = 0; i < Brackets.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (Brackets[i] != ')')
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                    if (i % 2 == 0)
                    {
                        if (Brackets[i] != '(')
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }

            }


            if (isBalanced)
            { Console.WriteLine("BALANCED"); }
            else
            { Console.WriteLine("UNBALANCED"); }

        }
    }
}