/*Problem 1. Strings in C#.
Describe the strings in C#.
What is typical for the string data type?
Describe the most important methods of the String class.*/

using System;
using System.Text;

class StringsInCSharp
{
    static void Main()
    {
        Console.Title = "Problem 1. Strings in C#";

        Console.WriteLine("Problem 1. Strings in C#!");
        PrintSeparateLine();

        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"A string is an object of type String whose value is text. Internally, the text is stored
            as a sequential read-only collection of Char objects. There is no null-terminating character at
            the end of a C# string; therefore a C# string can contain any number of embedded null characters
            ('\0'). The Length property of a string represents the number of Char objects it contains, not the
            number of Unicode characters. To access the individual Unicode code points in a string, use the
            StringInfo object.");
        sb.AppendLine(new string('-', 80));
        sb.AppendLine("The most important methods of the String class:\n");
        sb.AppendLine(" 1) string.Compare(): Compares two specified String objects and returns an integer that indicates their relative position in the sort order.\n");
        sb.AppendLine(" 2) string.Contains(): Returns a value indicating whether a specified substring occurs within this string.\n");
        sb.AppendLine(" 3) string.IndexOf(): Reports the zero-based index of the first occurrence of the specified Unicode character in this string or specified string in this instance.\n");
        sb.AppendLine(" 4) string.Split(): Returns a string array that contains the substrings, that are delimited by elements of a specified Unicode character array or string array.\n");
        sb.AppendLine(" 4) string.Substring(): Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string or a specified length.");

        Console.WriteLine(sb.ToString());
        PrintSeparateLine();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}