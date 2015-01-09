// Problem 14.* Current Date and Time
// Create a console application that prints the current date and time. Find out how in Internet.

using System;

class CurrentDateTime
{
    static void Main()
    {
        Console.Title = "Current Date and Time";
        Console.WriteLine(new string('-', 60));
        DateTime now = DateTime.Now;
        Console.WriteLine("The current date and time is: {0}", now);
        Console.WriteLine(new string('-', 60));
    }
}