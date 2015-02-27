/*Problem 1. Odd lines
Write a program that reads a text file and prints on the console its odd lines.*/

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        Console.WriteLine("Problem 1. Odd lines");
        PrintSeparateLine();

        string path = "../../input.txt";

        Console.WriteLine("> Print ood line of text file...\n");

        using (StreamReader reader = new StreamReader(path))
        {
            int count = 1;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine(line);
                }

                count++;
                line = reader.ReadLine();
            }
        }

        PrintSeparateLine();
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}