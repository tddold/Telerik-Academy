/*Problem 12. Remove words
Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class RemoveWords
{
    static string inputPath = "../../input.txt";
    static string outputPath = "../../output.txt";
    static string wordsPath = "../../words.txt";
    static List<string> result = new List<string>();
    static List<string> blackWords = new List<string>();

    public static void RemoveBlackWords()
    {
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            using (StreamReader reader = new StreamReader(wordsPath))
            {
                using (StreamReader reader1 = new StreamReader(inputPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] words = reader.ReadLine()
                            .Split(new char[] { ' ', ',', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(x => !blackWords.Contains(x))
                            .ToArray();

                        blackWords.AddRange(words);
                    }

                    while (!reader1.EndOfStream)
                    {


                        string[] words = reader1.ReadLine()
                            .Split(new char[] { ' ', ',', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(x => !blackWords.Contains(x))
                            .ToArray();

                        result.AddRange(words);
                    }


                }

                foreach (var word in result)
                {
                    writer.Write("{0} ", word);
                }

            }

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

        try
        {
            Console.Write("> Input ");
            PrintResult(inputPath);
            PrintSeparateLine();

            RemoveBlackWords();

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