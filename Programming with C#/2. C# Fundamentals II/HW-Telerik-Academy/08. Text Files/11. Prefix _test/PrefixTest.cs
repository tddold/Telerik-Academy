/*Problem 11. Prefix "test"
Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.*/

using System;
using System.IO;

class PrefixTest
{
    static string inputPath = "../../input.txt";
    static string outputPath = "../../output.txt";

    public static void RemovePrefix()
    {
        string input;

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            using (StreamReader reader = new StreamReader(inputPath))
            {
                input = reader.ReadToEnd();
            }

            int index = -1;
            int end = 0;
            do
            {
                if (index == 0)
                {
                    index = input.IndexOf("test", index);
                }
                else
                {
                    index = input.IndexOf("test", index + 1);
                }


                if (index >= 0 && index + 1 < input.Length)
                {
                    end = input.IndexOf('t', index + 1);
                }
                else
                {
                    continue;
                }

                if (index >= 0 && (index == 0 || input[index - 1] == ' '))
                {
                    input = input.Remove(index, end - index + 1).Trim();
                }
            }
            while (index >= 0);

            writer.WriteLine(input);
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
        Console.WriteLine("Problem 11. Prefix \"test\"");
        PrintSeparateLine();

        Console.Write("> Input ");
        PrintResult(inputPath);
        PrintSeparateLine();

        RemovePrefix();

        Console.Write("> Output ");
        PrintResult(outputPath);
        PrintSeparateLine();
    }


}