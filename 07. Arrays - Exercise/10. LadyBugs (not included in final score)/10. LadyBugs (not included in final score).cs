﻿/*10.	*LadyBugs
You are given a field size and the indexes of ladybugs inside the field. After that on every new line until the "end" command is given,
a ladybug changes its position either to its left or to its right by a given fly length. 

A command to a ladybug looks like this: "0 right 1". This means that the little insect placed on index 0 should fly one index to its right.
If the ladybug lands on a fellow ladybug, it continues to fly in the same direction by the same fly length. If the ladybug flies out of the field, it is gone.

For example, imagine you are given a field with size 3 and ladybugs on indexes 0 and 1.
If the ladybug on index 0 needs to fly to its right by the length of 1 (0 right 1) it will attempt to land on index 1
but as there is another ladybug there it will continue further to the right by additional length of 1,
landing on index 2. After that, if the same ladybug needs to fly to its right by the length of 1 (2 right 1), it will land somewhere outside of the field, so it flies away:
 
If you are given ladybug index that does not have ladybug there, nothing happens. If you are given ladybug index that is outside the field, nothing happens. 
Your job is to create the program, simulating the ladybugs flying around doing nothing. At the end, print all cells in the field separated by blank spaces. For each cell that has a ladybug on it print '1' and for each empty cells print '0'. For the example above, the output should be '0 1 0'. 

Input
•	On the first line you will receive an integer - the size of the field
•	On the second line you will receive the initial indexes of all ladybugs separated by a blank space. 
The given indexes may or may not be inside the field range
•	On the next lines, until you get the "end" command you will receive commands in the format: 
"{ladybug index} {direction} {fly length}"

Output
•	Print the all cells within the field in format: "{cell} {cell} … {cell}"
o	If a cell has ladybug in it, print '1'
o	If a cell is empty, print '0' 

Constrains
•	The size of the field will be in the range [0 … 1000]
•	The ladybug indexes will be in the range [-2,147,483,647 … 2,147,483,647]
•	The number of commands will be in the range [0 … 100] 
•	The fly length will be in the range [-2,147,483,647 … 2,147,483,647]
*/

using System;
using System.Linq;

namespace _10._LadyBugs__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            for (int i = 0; i < bugs.Length; i++)
            {
                if (bugs[i] < field.Length && bugs[i] >= 0)
                    field[bugs[i]] = 1;
            }

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                int BugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLenght = int.Parse(command[2]);

                if (BugIndex < 0 || BugIndex > field.Length - 1 || field[BugIndex] == 0)
                { continue; }
                if (((flyLenght >= field.Length - BugIndex - 1) && (direction == "right")) || ((flyLenght > BugIndex) && (direction == "left")))
                {
                    field[BugIndex] = 0;
                    continue;
                }

                field[BugIndex] = 0;
                if (direction == "right")
                {
                    for (int i = BugIndex +1*flyLenght; i <= field.Length-1 - BugIndex; i+=flyLenght)
                    {
                        if (field[i] == 0)
                        {
                            field[i] = 1;
                            break;
                        }
                    }
                }


                if (direction == "left")
                {
                    for (int i = BugIndex -1*flyLenght; i >= 0; i-=flyLenght)
                    {
                        if (field[i] == 0)
                        {
                            field[i] = 1;
                            break;
                        }
                    }
                }


            }

            Console.WriteLine(String.Join(' ', field));

        }
    }
}
