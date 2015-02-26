/*Problem 20. Palindromes
Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Palindromes
{
    public static List<char> GetPunctuation()
    {
        List<char> punct = new List<char>();
        const int maxPunctuation = 127;

        for (int i = 0; i <= maxPunctuation; i++)
        {
            if (char.IsPunctuation((char) i))
            {
                punct.Add((char) i);
            }
        }

        punct.Add((char) 32); // for space
        return punct;
    }

    public static List<string> SearchPalindromes(string[] words)
    {
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            bool isPolindrom = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    isPolindrom = false;
                    break;
                }
            }

            if (isPolindrom && word.Length > 1)
            {
                result.Add(word);
            }
        }

        return result;
    }

    public static void PrintPalindromes(List<string> result)
    {
        Console.WriteLine("Result is:");
        if (result.Count != 0)
        {
            foreach (string item in result)
            {
                Console.WriteLine(" - {0}", item);
            }
        }
        else
        {
            Console.WriteLine("In text is not found a palindromes");
        }
    }

    public static void Main()
    {
        Console.WriteLine("Problem 20. Palindromes");
        Console.WriteLine(new string('-', 40));

        string text = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";

        var punct = GetPunctuation();

        string[] words = text.Split(punct.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        var result = SearchPalindromes(words);

        PrintPalindromes(result);
        Console.WriteLine(new string('-', 40));
    }
}