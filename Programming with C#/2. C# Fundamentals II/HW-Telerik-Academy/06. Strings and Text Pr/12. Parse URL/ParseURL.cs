/*Problem 12. Parse URL
Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:
URL	Information
http://telerikacademy.com/Courses/Courses/Details/212	
[protocol] = http 
[server]   = telerikacademy.com 
[resource] = /Courses/Courses/Details/212
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ParseURL
{
    public static List<string> ParseAnURLAdress(string url)
    {
        List<string> parseUrl = new List<string>();
        int start = 0;
        int end = 0;

        start = url.IndexOf("://");
        end = url.IndexOf("/", start + 3);

        parseUrl.Add(url.Substring(0, start));        
        parseUrl.Add(url.Substring(start + 3, end - start - 3));
        parseUrl.Add(url.Substring(end));

         return parseUrl;
    }

    public static void PrintParsedURL(List<string> parsedUrl)
    {
        string[] formatElements = new string[] { "protocol", "server", "resuourse" };

        for (int i = 0; i < formatElements.Length; i++)
        {
            Console.WriteLine(" [{1, 10}] = {0}", parsedUrl[i], formatElements[i]);
        }
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 12. Parse URL");
        PrintSeparateLine();

        string url = "http://telerikacademy.com/Courses/Courses/Details/212"; //Console.ReadLine();

        var parsedUrl = ParseAnURLAdress(url);

        Console.Write("\nInput URL: {0}\n\n", url);
        PrintParsedURL(parsedUrl);
        PrintSeparateLine();
    }

    
}