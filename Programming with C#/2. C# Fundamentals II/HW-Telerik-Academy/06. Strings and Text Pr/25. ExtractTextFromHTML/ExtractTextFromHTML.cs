/*Problem 25. Extract text from HTML
Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:
<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
Output:
Title: News
Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ExtractTextFromHTML
{
    public static void ExtractText(string input)
    {
        StringBuilder title = new StringBuilder();
        StringBuilder text = new StringBuilder();

        bool isInTitle = false;
        bool isOutTitle = true;
        bool isInBody = false;
        bool isOutBody = true;
        bool isInText = true;

        string startTitle = "<title>";
        string endTitle = "</title>";
        string startText = "<a href=\"";
        string endText = "</p>";

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 7 && input.Substring(i, 7) == startTitle)
            {
                isInTitle = true;
                isOutTitle = false;
                i += 6;
                continue;
            }
            else if (i < input.Length - 8 && input.Substring(i, 8) == endTitle)
            {
                isInTitle = false;
                isOutTitle = true;
                i += 7;
                continue;
            }
            else if (i < input.Length - 9 && input.Substring(i, 9) == startText)
            {
                isInBody = true;
                isOutBody = false;
                i += 8;
                continue;
            }
            else if (i < input.Length - 4 && input.Substring(i, 4) == endText)
            {
                isInBody = false;
                isOutBody = true;
                i += 3;
                continue;
            }

            if (isInTitle)
            {
                title.Append(input[i]);
            }
            else if (isOutTitle && isOutBody)
            {
                continue;
            }
            else if (isInBody)
            {
                if (isInText)
                {
                    isInText = false;
                    int index = input.IndexOf("\">", i);
                    i = index + 2;
                }

                text.Append(input[i]);
            }
        }

        PrintResult(title, text);

    }

    public static void PrintResult(StringBuilder title, StringBuilder text)
    {
        Console.WriteLine("Output:");
        Console.WriteLine("\nTitle: {0}", title);

        string[] textResult = text.ToString().Split(new string[] { "\t", "\r\n", " ", "</a>" }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("\nText : {0}", string.Join(" ", textResult));
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    public static void Main()
    {
        Console.WriteLine("Problem 25. Extract text from HTML");
        PrintSeparateLine();

        string input =
@"<html>
    <head><title>News</title></head>
    <body><p><a href=""http://academy.telerik.com"">Telerik
      Academy</a>aims to provide free real-world practical
      training for young people who want to turn into
      skilful .NET software engineers.</p></body>
</html>";

        Console.WriteLine("Input: \n{0}\n", input);
        PrintSeparateLine();
        ExtractText(input);
        PrintSeparateLine();
    }
}