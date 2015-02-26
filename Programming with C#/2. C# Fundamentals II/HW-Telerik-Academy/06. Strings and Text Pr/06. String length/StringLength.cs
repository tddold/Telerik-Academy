/*Problem 6. String length
Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StringLength
{
    public static string GetStringLenght(string input)
    {
        StringBuilder sb = new StringBuilder(input);
        int stars = 20 - input.Length;

        sb.Append(new string('*', stars));

        return sb.ToString();
    }

    public static string ReadInput()
    {
        string input = Console.ReadLine().Trim();

        if (input.Length > 20)
        {
            input = input.Substring(0, 20);
        }

        return input;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 6. String length");
        PrintSeparateLine();

        Console.Write("Enter string: ");
        string input = ReadInput();

        Console.WriteLine("\nInput  -> {0}\nResult -> {1}", input, GetStringLenght(input));
        PrintSeparateLine();
    }

    
}