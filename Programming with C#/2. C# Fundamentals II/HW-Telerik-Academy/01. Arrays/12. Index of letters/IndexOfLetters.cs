/*Problem 12. Index of letters
Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class IndexOfLetters
{
    static void Main()
    {
        Console.Title = "Problem 12. Index of letters";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 12. Index of letters!");
        PrintSeparateLine();

        const int LiteralArrayLenght = 26;

        int[] literals = new int[LiteralArrayLenght];

        // create an array containing all letters from the alphabet (A-Z)
        for (char i = 'A'; i <= 'Z'; i++)
        {
            literals[i - 'A'] = i;
        }

        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            int index = Array.IndexOf(literals, char.ToUpperInvariant(word[i]));
            Console.WriteLine("\nLiteral '{0}' --> Index: {1, 2} --> ASCII Index: {2}", word[i], index, (int)word[i]);
        }

        PrintSeparateLine();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}