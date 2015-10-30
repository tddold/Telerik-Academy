namespace _04.LongestEqualSubseq
{
    /*
    4. Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
    Write a program to test whether the method works correctly.*/

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utility;

    public class LongestEqualSubsequance
    {
        public static void Main()
        {
            var listOfNumbers = ConsoleUtility.ReadSequenceOfElements<int>().ToList();

            var subsequenceOfEqualNumbers = ExtractLongestSubsequenceOfEqualOfNumbers(listOfNumbers);

            Console.WriteLine("The longest subsequance of equal elements is: {0}", string.Join(", ", subsequenceOfEqualNumbers));
        }

        private static List<int> ExtractLongestSubsequenceOfEqualOfNumbers(IList<int> sequence)
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

            for (int i = 0; i < bestCounter; i++)
            {
                longestEqualSubsequance.Add(resultNumber);
            }

            return longestEqualSubsequance;
        }
    }
}
