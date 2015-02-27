/*Problem 8. Replace whole word
Modify the solution of the previous problem to replace only whole words (not strings).*/

using System;
using System.IO;

class ReplaceWholeWord
{
    static string pathInput = "../../input.txt";
    static string pathOutput = "../../output.txt";
    

    static void Main()
    {
        Console.WriteLine("Problem 8. Replace whole word");
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
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    for (int i = line.IndexOf("start"); i != -1; i = line.IndexOf("start", i + 1))
                    {
                        if ((i - 1 < 0 || !Char.IsLetter(line[i - 1])) && (i + 5 >= line.Length) || !Char.IsLetter(line[i + 5]))
                        {
                            line = line.Insert(i, "finish").Remove(i + 6, 5);
                        }
                    }
                    writer.WriteLine(line);
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