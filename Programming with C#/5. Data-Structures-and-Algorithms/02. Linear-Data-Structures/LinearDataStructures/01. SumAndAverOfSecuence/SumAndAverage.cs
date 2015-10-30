namespace _01.SumAndAverOfSecuence
{
    /*
    1. Write a program that reads from the console a sequence of positive integer numbers.
    The sequence ends when empty line is entered.
    Calculate and print the sum and average of the elements of the sequence.
    Keep the sequence in List<int>.*/

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utility;

    class SumAndAverage
    {
        static void Main()
        {
            var numbers = ConsoleUtility.ReadSequenceOfElements<int>();
            var sumOfNUmbers = numbers.Sum();
            var averageOfNumbers = numbers.Average();

            PrintResult(sumOfNUmbers, averageOfNumbers);
        }

        private static void PrintResult(int sumOfNUmbers, double averageOfNumbers)
        {
            Console.WriteLine("Sum: {0}", sumOfNUmbers);
            Console.WriteLine("Average: {0}", averageOfNumbers);
        }
    }
}
