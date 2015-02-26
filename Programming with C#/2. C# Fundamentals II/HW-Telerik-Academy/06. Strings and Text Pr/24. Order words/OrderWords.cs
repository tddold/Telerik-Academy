/*Problem 24. Order words
Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Problem 24. Order words");
        Console.WriteLine(new string('-', 40));

        Console.Write("Enter a few words (separated by spaces): ");
        var words = Console.ReadLine().ToUpperInvariant().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

       //Array.Sort(words);
        words = words.OrderBy(x => x).ToList();

        Console.WriteLine("\nWords sorted in alphabetical order:\n{0}\n",
            string.Join("\n", words.Select(x => string.Format(" - {0}", x))));

        Console.WriteLine(new string('-', 40));
    }
}