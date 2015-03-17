/*Problem 1. StringBuilder.Substring
 *  Implement an extension method Substring(int index, int length) for the class StringBuilder 
 *  that returns new StringBuilder and has the same functionality as Substring in the class 
 *  String.
 **/

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
            Console.WriteLine("Test: StringBilder.Substring:");
            PrinSeparateLine();

            var sb = new StringBuilder("Implement an extension method...");
            int startIndex = 2;
            int endIndex = 5;

            Console.WriteLine("\nInput string: {0}", sb.ToString());
            Console.WriteLine("The substring in start posicion {1} to end position {2} is: {0}", sb.Substring(startIndex, endIndex).ToString(), startIndex, endIndex);
            PrinSeparateLine();
        }

        public static void PrinSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
