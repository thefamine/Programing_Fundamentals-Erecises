using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string a = Console.ReadLine();


                string leftPart = a.Substring(0, a.IndexOf(" "));
                long leftPartInt = long.Parse(leftPart);

                string rightPart = a.Substring(a.IndexOf(" ")+ 1 ,a.Length-a.IndexOf(" ")-1);
                long rightPartInt = long.Parse(rightPart);


                long SumOfDigits = 0;
                if (leftPartInt > rightPartInt)
                {

                    while (leftPartInt != 0)
                    {

                        SumOfDigits += leftPartInt % 10;
                        leftPartInt /= 10;


                            
                    }
                }
                else
                {

                    while (rightPartInt != 0)
                    {

                        SumOfDigits += rightPartInt % 10;
                        rightPartInt /= 10;

                    }

                }
                if (SumOfDigits < 0)
                    SumOfDigits *= -1;

                Console.WriteLine(SumOfDigits);
            }
        }
    }
}

