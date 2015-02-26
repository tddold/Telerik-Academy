/*Problem 8. Extract sentences
Write a program that extracts from a given text all sentences containing given word.
Example:
The word is: in
The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
Consider that the sentences are separated by . and the words – by non-letter symbols.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class ExtractSentences
{
    public static string GetExtractSentences(string input, string word)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder sb = new StringBuilder();

        int index = 0;
        int indexSb = -1;
        for (int i = 0; i < input.Length; i++)
        {
            int count = input.IndexOf('.', index);
            if (i <= count)
            {
                sb.Append(input[i]);
            }
            else
            {
                while (indexSb < sb.Length - 1 && sb.ToString().IndexOf(word, indexSb + 1) != -1)
                {
                    indexSb = sb.ToString().IndexOf(word, indexSb + 1);

                    if (indexSb > 0 && sb[indexSb - 1] == ' ' && indexSb < sb.Length - 2 && sb[indexSb + 2] == ' ')
                    {
                        result.Append(sb.ToString());
                    }
                }

                sb.Clear();
                index = i;
                indexSb = -1;
            }
        }

        indexSb = -1;
        while (indexSb < sb.Length - 1 && sb.ToString().IndexOf(word, indexSb + 1) != -1)
        {
            indexSb = sb.ToString().IndexOf(word, indexSb + 1);

            if (indexSb > 0 && sb[indexSb - 1] == ' ' && indexSb < sb.Length - 2 && sb[indexSb + 2] == ' ')
            {
                result.Append(sb.ToString());
            }
        }

        return result.ToString();
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    public static void Main()
    {
        //StreamReader reader = new StreamReader("input.txt");
        //Console.SetIn(reader);

        Console.WriteLine("Problem 8. Extract sentences");
        PrintSeparateLine();

        Console.WriteLine("\nEnter text:");
        string input = Console.ReadLine().Trim();

        Console.Write("\nEnter word:");
        string word = Console.ReadLine();
        PrintSeparateLine();

        if (GetExtractSentences(input, word).Length == 0)
        {
            Console.WriteLine("No matches found!");
        }
        else
        {
            Console.WriteLine("Result -> {0}", GetExtractSentences(input, word));
        }
        
        PrintSeparateLine();
    }
}