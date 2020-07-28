/*9.	*Kamino Factory
The clone factory in Kamino got another order to clone troops. 
But this time you are tasked to find the best DNA sequence to use in the production. 

You will receive the DNA length and until you receive the command "Clone them!" you will 
be receiving a DNA sequences of ones and zeroes, split by "!" (one or several).

You should select the sequence with the longest subsequence of ones. If there are several 
sequences with same length of subsequence of ones, print the one with the leftmost starting index,
if there are several sequences with same length and starting index, select the sequence with the 
greater sum of its elements.

After you receive the last command "Clone them!" you should print the collected information in the 
following format:

"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
"{DNA sequence, joined by space}"

Input / Constraints
•	The first line holds the length of the sequences – integer in range [1…100];
•	On the next lines until you receive "Clone them!" you will be receiving sequences (at least one) 
of ones and zeroes, split by "!" (one or several).

 Output
The output should be printed on the console and consists of two lines in the following format:
"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
"{DNA sequence, joined by space}"

*/

using System;
using System.Linq;

namespace _09._Kamino_Factory__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            //first input
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            //define variables

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;
            int[] bestSequence = new int[n];

            int sequenceCounnter = 0;

            //loop for input
            while (input != "Clone them!")
            {
                int[] currentSequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sequenceCounnter++;


                int bestCurrentLength = 1;
                int startIndex = 0;
                int currentSequenceSum = 0;


                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    int length = 1;

                    for (int j = i + 1; j < currentSequence.Length; j++)
                    {
                        if (currentSequence[i] == currentSequence[j]) 
                        { length++; }
                        else 
                        { break; }
                    }

                    if (length > bestCurrentLength) 
                    { 
                        bestCurrentLength = length; 
                        startIndex = i; 
                    }

                    currentSequenceSum += currentSequence[i];
                    length = 1;
                }

                //if last digit in input is 1
                if ((currentSequence[n - 1] == 1)) { currentSequenceSum++; }

                //check the best of inputs
                if ((bestCurrentLength > bestLength) ||
                        ((bestCurrentLength == bestLength) && (startIndex < bestStartIndex)) ||
                        ((bestCurrentLength == bestLength) && (startIndex == bestStartIndex) && (currentSequenceSum > bestSequenceSum))
                   )
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceIndex = sequenceCounnter;
                    bestSequence = currentSequence.ToArray();
                }

                input = Console.ReadLine();
            }

            //output
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}