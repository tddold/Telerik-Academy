/*Problem 22. Words count
Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WordsCount
{
    public static void GetLettersCount(string text)
    {
        string[] input = text.Split(new string[] { " ", ",", ".", "\t" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        
        int[] time = new int[input.Length];
        string[] words = new string[input.Length];
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (!words.Contains(input[i]))
            {
                words[count] = input[i];
                time[count]++;
                count++;
            }
            else
            {
                int index = Array.IndexOf(words, input[i]);
                time[index]++;
            }
        }

        PrintResult(words, time);
    }

    public static void PrintResult(string[] letters, int[] time)
    {
        Console.WriteLine("\nResult is:");
        for (int i = 0; i < letters.Length; i++)
        {
            if (time[i] == 0)
            {
                return;
            }

            Console.WriteLine(" word - {0,11} ; times - {1}", letters[i], time[i]);
        }
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 22. Words count");
        PrintSeparateLine();

        Console.WriteLine("\nEnter text:");
        string text = Console.ReadLine();

        //string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";

        GetLettersCount(text);
        PrintSeparateLine();
    }
}
