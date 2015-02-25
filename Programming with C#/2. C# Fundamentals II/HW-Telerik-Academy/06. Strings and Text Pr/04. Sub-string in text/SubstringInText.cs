/*Problem 4. Sub-string in text
Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:
The target sub-string is "in"
The text is as follows:
 * |We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So |we are drinking all the day. We will move out of it in 5 days.                                       
 * 
The result is: 9
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class SubstringInText
{
    static void Main()
    {
        // string inputText = @"We are living in an yellow submarine. We don't have anything else.
        // Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5     days.";
        // string target = "in";

       

        Console.Title = "Problem 4. Sub-string in text";

        Console.WriteLine("Problem 4. Sub-string in text!");
        PrintSeparateLine();

        Console.Write("Enter text: ");
        string inputText = Console.ReadLine();

        Console.Write("\nEnter target sub-string: ");
        string target = Console.ReadLine();

        Console.WriteLine("\nResult is: {0}", FindNumberOfTimesTargetCnataine(inputText, target));
        PrintSeparateLine();
    }

    static int FindNumberOfTimesTargetCnataine(string inputText, string target)
    {
        int targetCount = 0;
        int index = -1;

        while (inputText.IndexOf(target, index + 1) != -1)
        {
            index = inputText.IndexOf(target, index + 1);
            targetCount++;
        }

        return targetCount;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}