/*Problem 17. Longest string
 * Write a program to return the string with maximum length from an array of strings.
 * Use LINQ.*/


namespace Longest_string
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Longeststring
    {
        static void Main()
        {
            Console.WriteLine("Write a program to return the string with maximum length from an array of strings");
            PrintSeparateLine();

            string[] input = 
            {
                "buy",
                "query",
                "hi",
                "maximum",
                "length"
            };

            var sorted =
                from str in input
                orderby str.Length
                select str;

            string longest = sorted.LastOrDefault();

            Console.WriteLine("\nThe element whid max lenght is: {0}", longest);

            PrintSeparateLine();

        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
