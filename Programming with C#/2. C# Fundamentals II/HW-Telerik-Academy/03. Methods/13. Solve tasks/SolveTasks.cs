/*Problem 13. Solve tasks
Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
    The decimal number should be non-negative
    The sequence should not be empty
    a should not be equal to 0
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class SolveTasks
{
    static void Main()
    {
        Console.Title = "Problem 13. Solve tasks";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 13. Solve tasks!");
        PrintSeparateLine();

        int choice = 0;

        do
        {
            Console.WriteLine("Main menu");
            Console.WriteLine("   1) Reverses the digits of a number (1)");
            Console.WriteLine("   2) Calculates the average of a sequence of integers (2)");
            Console.WriteLine("   3) Solves a linear equation a * x + b = 0 (3)");
            PrintSeparateLine();

            Console.Write("Enter your choice:");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ReversDigitsOfNumber();
                    return;
                case 2:
                    AverageOfSequenceOfNumbers();
                    return;
                case 3:
                    SolveLinerEquation();
                    return;
                default:
                    choice = 0;
                    break;
            }
        }
        while (choice == 0);
    }

    private static void ReversDigitsOfNumber()
    {
        decimal number;

        do
        {
            Console.Write("Enter a positive number (real or integer):");
            number = decimal.Parse(Console.ReadLine());
        }
        while (!(number > 0));

        string nArray = number.ToString();

        string result = string.Empty;

        for (int i = nArray.Length - 1; i >= 0; i--)
        {
            result += nArray[i];
        }

        Console.WriteLine("\nResult: {0} -> {1}\n", number, decimal.Parse(result));
        PrintSeparateLine();
    }

    private static void AverageOfSequenceOfNumbers()
    {
        bool notEmpty = true;
        double[] numbers;

        do
        {
            if (!notEmpty)
            {
                Console.WriteLine("There sequence cannot be empty!");
            }

            Console.Write("Enter numbers, separated by a comma: ");
            numbers = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => double.Parse(x))
            .ToArray();

            notEmpty = numbers.Length > 0;
        }
        while (!notEmpty);

        double result = numbers.Sum() / numbers.Length;
        Console.WriteLine("Average: {0:F2}", result);
        PrintSeparateLine();
    }

    private static void SolveLinerEquation()
    {
        decimal a = 0;

        do
        {
            Console.Write("Enter a non-zero number a: ");
            a = decimal.Parse(Console.ReadLine());
        }
        while (a == 0);

        Console.Write("Enter a non-zero number b: ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Result -> x = - b/ a = {0}", -b / a);
        PrintSeparateLine();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}