/*Problem 4. Download file
Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.*/

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Problem 4. Download file");
        PrintSeparateLine();

        using (WebClient Client = new WebClient())
        {
            try
            {
                Console.WriteLine("\nStart downloading...");
                Client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", @"..\..\Ninja.png");
                Console.WriteLine("\n-> The download was sucessful!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nGoodbye!\n");
            }
        }

        PrintSeparateLine();
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}