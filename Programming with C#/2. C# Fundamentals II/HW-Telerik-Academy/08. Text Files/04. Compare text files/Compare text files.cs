/*Problem 4. Compare text files
Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.*/

using System;
using System.IO;

class Program
{
    static int sameLine = 0, diffLine = 0;
    static void Main()
    {
        Console.WriteLine("Problem 4. Compare text files");
        PrintSeparateLine();

        string pathFile1 = "../../file1.txt";
        string pathFile2 = "../../file2.txt";

        CommpareTwoFiles(pathFile1, pathFile2);

        Console.WriteLine("\nSame line: {0}", sameLine);
        Console.WriteLine("\nDifferent line: {0}", diffLine);
        PrintSeparateLine();
    }

    public static void CommpareTwoFiles(string pathFile1, string pathFile2)
    {
        using (StreamReader reader1 = new StreamReader(pathFile1))
        {
            using (StreamReader reader2 = new StreamReader(pathFile2))
            {
                while (!reader1.EndOfStream || !reader2.EndOfStream)
                {
                    string line1 = reader1.ReadLine();
                    string line2 = reader2.ReadLine();

                    if (line1.CompareTo(line2) == 0)
                    {
                        sameLine++;
                    }
                    else
                    {
                        diffLine++;
                    }
                }
            }
        }
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}