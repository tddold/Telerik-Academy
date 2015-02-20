/*Problem 1. Say Hello
Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:
|input	|output
|Peter	|Hello, Peter!
 */

using System;
using System.Globalization;
using System.Threading;

class SayHello
{
    static void Main()
    {
        Console.Title = "Problem 1. Say Hello";

        Console.WriteLine("Problem 1. Say Hello!");
        PrintSeparateLine();

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        PrintYorName(userName);
        PrintSeparateLine();
    }

    static void PrintYorName(string userName)
    {
        Console.WriteLine("\nHello, {0}!", userName);
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}