/*Problem 10. Extract text from XML
Write a program that extracts from given XML file all the text without the tags.
Example:
<?xml version="1.0">
 * <student>
 *      <name>Pesho</name>
 *      <age>21</age>
 *      <interests count="3">
 *          <interest>Games</interest>
 *          <interest>C#</interest>
 *          <interest>Java</interest>
 *      </interests>
 * </student>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ExtractTextFfomXML
{
    static string inputPath = "../../input.xml";
    static string outputPath = "../../output.txt";

    public static void ReadeXmlFile()
    {
        using (StreamReader reader = new StreamReader(inputPath))
        {
            string xml = reader.ReadToEnd();

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                Console.WriteLine("\n> Extract xml file:\n");
                writer.Write(GetResult(xml));
                Console.WriteLine("> End of extract...\n");
            }
        }
    }

    public static string GetResult(string xml)
    {
        StringBuilder result = new StringBuilder();
        StringBuilder current = new StringBuilder();
        bool isInTag = false;

        foreach (var ch in xml)
        {
            if (isInTag)
            {
                if (ch == '>')
                {
                    isInTag = false;
                }

                continue;
            }
            else
            {
                if (ch == '<')
                {
                    if (current.Length > 0)
                    {
                        result.AppendLine(current.ToString());
                        current.Clear();
                    }

                    isInTag = true;
                }
                else
                {
                    if (ch == '\r' || ch == ' ' || ch == '\n')
                    {
                        continue;
                    }
                    else
                    {
                        current.Append(ch.ToString());
                    }
                }
            }
        }


        return result.ToString();
    }

    public static void PrintResult()
    {
        using (StreamReader reader = new StreamReader(outputPath))
        {
            Console.WriteLine("\n> Result:\n");
            Console.WriteLine(reader.ReadToEnd());
            Console.WriteLine("> End of file...\n");
        }
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 10. Extract text from XML");
        PrintSeparateLine();

        ReadeXmlFile();
        PrintSeparateLine();

        PrintResult();
        PrintSeparateLine();
    }
}