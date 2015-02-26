/*Problem 21. Letters count
Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LettersCount
{
    public static void GetLettersCount(string text)
    {
        string[] inputText = text.Split(new string[]{ " ", ",", ".", "\t"},StringSplitOptions.RemoveEmptyEntries).ToArray();

        StringBuilder sb = new StringBuilder();

        foreach (string ch in inputText)
        {
            sb.Append(ch);
        }

        int[] time = new int[sb.Length];
        char[] letters = new char[sb.Length];
        int count = 0;

        for (int i = 0; i < sb.Length; i++)
        {
            if (!letters.Contains(sb[i]))
            {
                letters[count] = sb[i];
                time[count]++;
                count++;
            }
            else
            {
                int index = Array.IndexOf(letters, sb[i]);
                time[index]++;
            }
        }

        PrintResult(letters, time);
    }

    public static void PrintResult(char[] letters, int[] time)
    {
        Console.WriteLine("\nResult is:");
        for (int i = 0; i < letters.Length; i++)
        {
            if (time[i] == 0)
            {
                return;
            }

            Console.WriteLine("letter - {0} ; times - {1}", letters[i], time[i]);
        }
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
    static void Main()
    {
        Console.WriteLine("Problem 21. Letters count");
        PrintSeparateLine();

        Console.WriteLine("\nEnter text:");
        string text = Console.ReadLine();

        //string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";

        GetLettersCount(text);
        PrintSeparateLine();
    }
}