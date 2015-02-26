/*Problem 23. Series of letters
Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:
|input	                    |output
|aaaaabbbbbcdddeeeedssaa    |abcdedsa
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SeriesOfLetters
{
    public static HashSet<char> CheckForSriesOfLetters(string text)
    {
        HashSet<char> result = new HashSet<char>();

        for (int i = 0; i < text.Length; i++)
        {
            result.Add(text[i]);
        }

        return result;
    }

    private static void PrintResult(HashSet<char> result)
    {
        Console.WriteLine("\nResult is:");
        foreach (var ch in result)
        {
            Console.Write(ch);
        }

        Console.WriteLine();
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    public static void Main()
    {
        Console.WriteLine("Problem 23. Series of letters");
        PrintSeparateLine();

        Console.Write("\nEnter series of letters: ");
        string text = Console.ReadLine().Trim();

        //string text = "aaaaabbbbbcdddeeeedssaa";

        var result = CheckForSriesOfLetters(text);

        PrintResult(result);
        PrintSeparateLine();
    }




}