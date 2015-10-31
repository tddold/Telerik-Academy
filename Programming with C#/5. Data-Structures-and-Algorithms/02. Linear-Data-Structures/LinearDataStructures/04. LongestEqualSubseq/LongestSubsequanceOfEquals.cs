namespace _04.LongestEqualSubseq
{
    /*
    4. Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
    Write a program to test whether the method works correctly.*/

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utility;

    public class LongestSubsequanceOfEquals
    {
        public static void Main()
        {
            Console.WriteLine("Enter number for collection of numbers.");
            Console.WriteLine("Each one on a different rows.");
            Console.WriteLine("If row is empty end the collection.");

            var listOfNumbers = ConsoleUtility.ReadSequenceOfElements<int>().ToList();

            var subsequenceOfEqualNumbers = FindLongestSubsequence(listOfNumbers);

            Console.WriteLine("The longest subsequence of equal elements is: {0}", string.Join(", ", subsequenceOfEqualNumbers));
        }

        public static List<int> FindLongestSubsequence(IList<int> sequence)
        {
            var bestCounter = 1;
            var currentCounter = 1;
            var resultNumber = sequence[0];
            var longestEqualSubsequance = new List<int>();

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentCounter++;
                }
                else
                {
                    currentCounter = 1;
                }

                if (currentCounter >= bestCounter)
                {
                    bestCounter = currentCounter;
                    resultNumber = sequence[i];
                }
            }

            if (bestCounter == 1)
            {
                longestEqualSubsequance.Add(sequence[sequence.Count - 1]);
            }
            else
            {
                for (int i = 0; i < bestCounter; i++)
                {
                    longestEqualSubsequance.Add(resultNumber);
                }
            }

            return longestEqualSubsequance;
        }
    }
}
