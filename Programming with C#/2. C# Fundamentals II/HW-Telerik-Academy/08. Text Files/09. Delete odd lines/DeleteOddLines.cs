/*Problem 9. Delete odd lines
Write a program that deletes from given text file all odd lines.
The result should be in the same file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class DeleteOddLines
{
    static string path = "../../input.txt";

    public static void PrintResult()
    {
        using (StreamReader reader = new StreamReader(path))
        {
            Console.WriteLine("\n> Result:\n");
            Console.WriteLine(reader.ReadToEnd());
            Console.WriteLine("> End of file...\n");
        }
    }

    public static void WriteOddLine(List<string> oddLine)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (var line in oddLine)
            {
                writer.WriteLine(line);
            }
        }
    }

    public static List<string> ReadOddLine()
    {
        List<string> oddLine = new List<string>();

        using (StreamReader reader = new StreamReader(path))
        {
            int count = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (count % 2 == 0)
                {
                    oddLine.Add(reader.ReadLine());
                }

                count++;
                line = reader.ReadLine();
            }
        }

        return oddLine;
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 9. Delete odd lines");
        PrintSeparateLine();

        Console.WriteLine("> Remove ood line of text file...\n");

        WriteOddLine(ReadOddLine());
        PrintResult();

        PrintSeparateLine();
    }
}