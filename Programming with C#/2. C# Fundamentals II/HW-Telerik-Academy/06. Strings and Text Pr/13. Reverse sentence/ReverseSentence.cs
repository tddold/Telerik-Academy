/*Problem 13. Reverse sentence
Write a program that reverses the words in given sentence.
Example:
|input	                                |output
|C# is not C++, not PHP and not Delphi!	|Delphi not and PHP, not C++ not is C#!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ReverseSentence
{
    public static string GetReverseSentence(string input)
    {
        StringBuilder result = new StringBuilder(input);
        result.Replace("!", string.Empty);

        string[] word = result.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < word.Length - 1; i++)
        {
            result.Append(word[i].ToString());
        }

        Stack<string> words = new Stack<string>();

        char sign = input[input.Length - 1];

        for (int i = 0; i < word.Length; i++)
        {
            words.Push(word[i]);
        }

        result.Clear();
        foreach (var item in words)
        {
            result.Append(item + " ");
        }

        return result.Append("!").Replace(" ", string.Empty, result.Length - 2, 1).ToString();
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    public static void Main()
    {
        Console.WriteLine("Problem 13. Reverse sentence");
        PrintSeparateLine();

        string input = "C# is not C++, not PHP and not Delphi!";

        Console.WriteLine("Input  -> {0}", input);

        Console.WriteLine("\nResult -> {0}", GetReverseSentence(input));
        PrintSeparateLine();
    }
}