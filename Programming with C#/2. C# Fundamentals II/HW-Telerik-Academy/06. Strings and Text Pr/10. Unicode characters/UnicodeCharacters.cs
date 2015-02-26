/*Problem 10. Unicode characters
Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example
|input	|output
|Hi!	|\u0048\u0069\u0021*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UnicodeCharacters
{
    private static string ConvertToUnicode(string input)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var ch in input)
        {
            sb.Append(String.Format("\\u{0:X4}", (int) ch));
        }

        return sb.ToString();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 10. Unicode characters");
        PrintSeparateLine();

        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        Console.WriteLine("\n{0}", ConvertToUnicode(input));
        PrintSeparateLine();
    }
}