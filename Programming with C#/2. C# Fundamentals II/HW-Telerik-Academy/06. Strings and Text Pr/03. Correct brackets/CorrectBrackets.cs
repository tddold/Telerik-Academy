/*Problem 3. Correct brackets
Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CorrectBrackets
{
    static void Main()
    {
        Console.Title = "Problem 3. Correct brackets";

        Console.WriteLine("Problem 3. Correct brackets!");
        PrintSeparateLine();

        Console.Write("Enter expression:");
        string exp = Console.ReadLine();

        Console.WriteLine("\nThe expression is {0}!", IsValidExpression(exp) ? "corect" : "incorect");
        PrintSeparateLine();
    }

    static bool IsValidExpression(string exp)
    {
        int bracketsCount = 0;

        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == '(')
            {
                bracketsCount++;
            }
            else if (exp[i] == ')')
            {
                bracketsCount--;
            }
        }

        if (bracketsCount < 0)
        {
            return false;
        }

        return bracketsCount == 0;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}