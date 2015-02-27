/*Problem 7. Replace sub-string
Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubstring
{
    static string pathInput = "../../input.txt";
    static string pathOutput = "../../output.txt";

    static void Main()
    {
        Console.WriteLine("Problem 7. Replace sub-string");
        PrintSeparateLine();

        ReplaceSubstrings();
        PrintReplasedFile();

        PrintSeparateLine();
    }

    private static void PrintReplasedFile()
    {
        using (StreamReader reader = new StreamReader(pathOutput))
        {
            Console.WriteLine("\n> Result:\n");
            Console.WriteLine(reader.ReadToEnd());
            Console.WriteLine("> End of file...\n");

        }
    }

    private static void ReplaceSubstrings()
    {
        using (StreamWriter writer = new StreamWriter(pathOutput))
        {
            using (StreamReader reader = new StreamReader(pathInput))
            {
                while (!reader.EndOfStream)
                {
                    writer.WriteLine(Regex.Replace(reader.ReadLine(), "start", "finish", RegexOptions.IgnoreCase));
                }
            }
        }

        Console.WriteLine(">Replacing done!");
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}