/*Problem 6. Sum integers
You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:
|input	            |output
|"43 68 9 23 318"	|461
*/

namespace _06.SumIntegers
{
    using System;
    class SumIntegers
    {
        static void Main()
        {
            Console.Title = "Problem 6. Sum integers";

            Console.WriteLine("Problem 6. Sum integers!");
            PrintSeparateLine();

            Console.Write("Enter sequence of positive integers, separated by spaces: ");
            string seqOfNumbers = Console.ReadLine();

            string[] number = seqOfNumbers.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int num = 0;
                sum += int.TryParse(number[i], out num) ? num : 0;
            }

            Console.WriteLine("\nSum of numbers: {0}", sum);
            PrintSeparateLine();
        }

        static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
