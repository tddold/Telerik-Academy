/*Problem 2. Concatenate text files
Write a program that concatenates two text files into another text file.*/

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        Console.WriteLine("Problem 2. Concatenate text files");
        PrintSeparateLine();

        string pathFile1 = "../../file1.txt";
        string pathFile2 = "../../file2.txt";
        string pathResult = "../../result.txt";

        ReadFileAndWrite(pathFile1, pathResult);
        ReadFileAndWrite(pathFile2, pathResult);

        PrintResult(pathResult);
        ClearResultFile(pathResult);

        PrintSeparateLine();
    }

    public static void ClearResultFile(string pathResult)
    {
        using (StreamWriter writer = new StreamWriter(pathResult))
        {
            writer.WriteLine(string.Empty);
        }
    }

    public static void PrintResult(string pathResult)
    {
        using (StreamReader reader = new StreamReader(pathResult))
        {
            Console.WriteLine("> Result:\n");

            Console.WriteLine(reader.ReadToEnd());

            Console.WriteLine("\n> End of file...\n");
        }
    }

    public static void ReadFileAndWrite(string pathFile, string pathResult)
    {
        using (StreamWriter writer = new StreamWriter(pathResult, true))
        {
            using (StreamReader reader = new StreamReader(pathFile))
            {
                while (!reader.EndOfStream)
                {
                    writer.WriteLine(reader.ReadLine());
                }
            }
        }
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}