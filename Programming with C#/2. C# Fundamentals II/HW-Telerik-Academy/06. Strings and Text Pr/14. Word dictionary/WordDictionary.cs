/*Problem 14. Word dictionary
A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:
|input	    |output
|.NET	    |platform for applications from Microsoft
|CLR	    |managed execution environment for .NET
|namespace	|hierarchical organization of classes
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WordDictionary
{
    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    public static void Main()
    {
        Console.WriteLine("Problem 14. Word dictionary");
        PrintSeparateLine();

        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("NAMESPACE", "hierarchical organization of classes");

        Console.WriteLine("Dictionary words: {0}\n", string.Join(", ", dictionary.Keys));

        Console.Write("Enter a word to see its explanation: ");
        string word = Console.ReadLine().ToUpper().Trim();

        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine("\n{0} -> {1}", word, dictionary[word]);
        }
        else
        {
            Console.WriteLine("\nDictionary does not contain word \"{0}\".", word);
        }

        PrintSeparateLine();
    }
}