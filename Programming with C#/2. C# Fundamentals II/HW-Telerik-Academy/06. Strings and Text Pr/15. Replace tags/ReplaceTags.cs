/*Problem 15. Replace tags
Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:
|input	
<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 
 |output
 <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class ReplaceTags
{
    public static string GetReplaceTags(string input)
    {
        StringBuilder result = new StringBuilder();
        string urlStart = "[URL=";
        string urlEnd = "[/URL]";
        string urlClose = "]";

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 9 && input.Substring(i, 9) == "<a href=\"")
            {
                result.Append(urlStart);
                while (input[i] != '"')
                {
                    i++;
                }
            }
            else if (i < input.Length - 4 && input.Substring(i, 4) == "</a>")
            {
                result.Append(urlEnd);
                while (input[i] != '>')
                {
                    i++;
                }
            }
            else if (i < input.Length - 2 && input.Substring(i, 2) == "\">")
            {
                result.Append(urlClose);
                while (input[i] != '>')
                {
                    i++;
                }
            }
            else
            {
                result.Append(input[i].ToString());
            }
        }

        return result.ToString();
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    public static void Main()
    {
        //StreamReader reader = new StreamReader("..\\..\\input.txt");
        //Console.SetIn(reader);

        Console.WriteLine("Problem 15. Replace tags");
        PrintSeparateLine();

        string input = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        Console.WriteLine("Input: \n{0}", input);
        Console.WriteLine();
        Console.WriteLine("Result: \n{0}", GetReplaceTags(input));
        PrintSeparateLine();
    }
}