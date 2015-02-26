/*Problem 9. Forbidden words
We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
Forbidden words: PHP, CLR, Microsoft
The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class ForbiddenWords
{
    public static string ReplaceForbiddenWord(string[] words, string input)
    {
        StringBuilder sb = new StringBuilder(input);

        for (int i = 0; i < words.Length; i++)
        {
            sb.Replace(words[i], new string('*', words[i].Length));
        }

        return sb.ToString();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    public static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\input.txt");
        //Console.SetIn(reader);

        Console.WriteLine("Problem 9. Forbidden words");
        PrintSeparateLine();

        Console.WriteLine("\nEmter text:");
        string input = Console.ReadLine().Trim();

        Console.Write("\nEnter words: ");
        string inputWurds = Console.ReadLine();

        // string[] words = new string[] { "PHP", "CLR", "Microsoft" };
        string[] words = inputWurds.Split(new char[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        PrintSeparateLine();
        Console.WriteLine(ReplaceForbiddenWord(words, input));
        PrintSeparateLine();
    }
}