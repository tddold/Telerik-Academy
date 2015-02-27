/*Problem 13. Count words
Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class CountWords
{
    static string inputPath = "../../input.txt";
    static string outputPath = "../../output.txt";
    static string wordsPath = "../../words.txt";
    static Dictionary<string, int> countWords = new Dictionary<string, int>();
    static StringBuilder result = new StringBuilder();

    public static void WordsCount(string[] words, string input)
    {
        int[] count = new int[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            int index = -1;
            do
            {
                index = input.IndexOf(words[i], index + 1);
                if (index >= 0)
                {
                    count[i]++;
                }

            } while (index >= 0);
        }

        for (int i = 0; i < words.Length; i++)
        {
            countWords.Add(words[i], count[i]);
        }
    }

    public static void PrintResult(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            Console.WriteLine("File:\n");
            Console.WriteLine(reader.ReadToEnd());
            Console.WriteLine("\n> End of file...\n");
        }
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 12. Remove words");
        PrintSeparateLine();

        string[] words;
        string input;

        Console.Write("> Input ");
        PrintResult(inputPath);
        PrintSeparateLine();


        try
        {
            using (StreamReader readWord = new StreamReader(wordsPath))
            {
                using (StreamReader readInput = new StreamReader(inputPath))
                {
                    words = readWord.ReadToEnd().Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    input = readInput.ReadToEnd();

                    WordsCount(words, input);
                }
            }

            foreach (var word in countWords.OrderByDescending(key => key.Value))
            {
                result.AppendLine(String.Format("{0} ({1} times)", word.Key, word.Value));
            }

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.Write(result);
            }

            Console.Write("> Output ");
            PrintResult(outputPath);
            PrintSeparateLine();
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileLoadException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (EndOfStreamException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}