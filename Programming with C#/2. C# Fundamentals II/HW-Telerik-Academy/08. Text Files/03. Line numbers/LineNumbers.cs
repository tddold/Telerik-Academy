/*Problem 3. Line numbers
Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.*/

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        Console.WriteLine("Problem 3. Line numbers");
        PrintSeparateLine();

        string pathInput = @"..\..\input.txt";
        string pathResult = @"..\..\result.txt";

        AddLineNumbers(pathInput, pathResult);
        PrintSeparateLine();
    }

    public static void AddLineNumbers(string pathInput, string pathResult)
    {
        Console.WriteLine("\n> Add line number of text file...\n");

        using (StreamReader reader = new StreamReader(pathInput))
        {
            StreamWriter write = new StreamWriter(pathResult);

            string line = reader.ReadLine();
            int count = 1;
            using (write)
            {
                while (line != null)
                {
                    Console.WriteLine(" {0,3}) {1}", count, line);
                    count++;
                    line = reader.ReadLine();
                }
            }
        }

        Console.WriteLine("\n> End to add line numbers!");
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}