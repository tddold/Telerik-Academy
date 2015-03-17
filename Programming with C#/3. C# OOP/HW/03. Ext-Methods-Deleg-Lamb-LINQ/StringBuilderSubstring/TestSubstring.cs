/*Problem 1. StringBuilder.Substring
 *  Implement an extension method Substring(int index, int length) for the class StringBuilder 
 *  that returns new StringBuilder and has the same functionality as Substring in the class 
 *  String.
 * Problem 2. IEnumerable extensions
 *  Implement a set of extension methods for IEnumerable<T> that implement the following group 
 *  functions: sum, product, min, max, average.*/

namespace StringBuilderSubstring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TestSubstring
    {
        public static void Main()
        {
            Console.WriteLine("Test StringBilder.Substring:");
            PrinSeparateLine();

            var sb = new StringBuilder("Implement an extension method...");
            int startIndex = 2;
            int endIndex = 5;

            Console.WriteLine("\nInput string: {0}", sb.ToString());
            Console.WriteLine("The substring in start posicion {1} to end position {2} is: {0}", sb.Substring(startIndex, endIndex).ToString(), startIndex, endIndex);
            PrinSeparateLine();

            var source = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine("\nThe sum is {0} = {1}", string.Join(" + ", source), source.Sum());
            PrinSeparateLine();

            Console.WriteLine("\nThe product is {0} = {1}", string.Join(" * ", source), source.Product());
            PrinSeparateLine();

            Console.WriteLine("\nThe min velement is: {0}", source.Min());
            PrinSeparateLine();

            Console.WriteLine("\nThe min velement is: {0}", source.Max());
            PrinSeparateLine();

            Console.WriteLine("\nThe average of sequence {0} is: {1}", string.Join(", ", source), source.Average());
            PrinSeparateLine();
        }

        public static void PrinSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
