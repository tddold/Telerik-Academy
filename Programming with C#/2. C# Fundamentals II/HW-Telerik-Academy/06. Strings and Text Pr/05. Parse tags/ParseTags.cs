/*Problem 5. Parse tags
You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ParseTags
{
    public static string ChandgeTheText(string input)
    {
        bool isInTag = false;
        bool isOutTag = true;
        bool isInBarscets = false;
        bool isOutBarsckets = true;

        StringBuilder sb = new StringBuilder();
        StringBuilder sbInside = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '<' && i + 1 < input.Length && input[i + 1] != '/')
            {
                isInBarscets = true;
                isOutBarsckets = false;
                isInTag = true;
                isOutTag = false;

            }
            else if (input[i] == '<' && i + 1 < input.Length && input[i + 1] == '/')
            {
                isInBarscets = true;
                isOutBarsckets = false;
                isInTag = false;
                isOutTag = true;

            }
            else if (isInBarscets)
            {
                while (input[i] != '>')
                {
                    i++;
                }

                isInBarscets = false;
                isOutBarsckets = true;
            }
            else if (isInTag && isOutBarsckets)
            {
                sbInside.Append(input[i]);
            }
            else if (isOutTag && isOutBarsckets)
            {
                if (sbInside.Length != 0)
                {
                    sb.Append(sbInside.ToString().ToUpper());
                    sbInside.Clear();
                }

                sb.Append(input[i]);
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }

        return sb.ToString();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    public static void Main()
    {
        Console.WriteLine("Problem 5. Parse tags");
        PrintSeparateLine();

        //string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        string input = Console.ReadLine().Trim();

        Console.WriteLine("\n{0}",ChandgeTheText(input));
        PrintSeparateLine();
    }
}