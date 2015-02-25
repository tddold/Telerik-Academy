/*Problem 2. Reverse string
Write a program that reads a string, reverses it and prints the result at the console.
Example:
|input	|output
|sample	|elpmas
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.Title = "*Problem 2. Reverse string";

        Console.WriteLine("*Problem 2. Reverse string!");
        PrintSeparateLine();

        Console.Write("Enter string to revers: ");
        string input = Console.ReadLine();
        Console.WriteLine("\nInput string {0} -> {1} reversed.", input, ReversString(input));
        PrintSeparateLine();
    }

    static string ReversString(string input)
    {
        char[] inputArray = input.ToCharArray();
        Array.Reverse(inputArray);

        return new string(inputArray);
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}