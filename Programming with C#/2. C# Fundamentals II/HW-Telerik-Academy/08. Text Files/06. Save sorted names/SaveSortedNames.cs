/*Problem 6. Save sorted names
Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:
|input.txt	|output.txt
|Ivan       |George 
|Peter      |Ivan 
|Maria      |Maria 
|George	    |Peter
*/

using System;
using System.IO;

class SaveSortedNames
{
    static string pathInput = "../../input.txt";
    static string pathOutput = "../../output.txt";
    static void Main()
    {
        Console.WriteLine("Problem 6. Save sorted names");
        PrintSeparateLine();

        GetSortedFile();
        PrintOutputFile();

        PrintSeparateLine();
    }

    private static void PrintOutputFile()
    {
        using (StreamReader reader = new StreamReader(pathOutput))
        {
            Console.WriteLine("> Result:");
            Console.WriteLine(" {0}", reader.ReadToEnd());
            Console.WriteLine("> End of file...\n");
        }
    }

    public static void GetSortedFile()
    {
        using (StreamReader reader = new StreamReader(pathInput))
        {
            string[] file = reader.ReadToEnd()
                .Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(file);

            using (StreamWriter writer = new StreamWriter(pathOutput))
            {
                foreach (var item in file)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }

    private static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}