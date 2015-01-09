//Problem 7. Print First and Last Name
//Create console application that prints your first and last name, each at a separate line.

using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        Console.Title = "Print First and Last Name";

        string firstName = "Ivan";
        string lastName = "Ivanov";

        Console.WriteLine("First name is: {0}\nLast name is : {1}", firstName, lastName);
    }
}