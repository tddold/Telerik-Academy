/*
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
using System.Text;
using System.Threading;

public class SolveTaks
{
    public static void ReversNumber()
    {
        Console.WriteLine("\n{0}", new string('-', 40));

        decimal num = 0;
        do
        {
            Console.Write("Enter a non - negativ number:");
            num = decimal.Parse(Console.ReadLine());
        }
        while (num < 0);

        string number = num.ToString();
        int[] array = new int[number.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = number[number.Length - 1 - i] - 48;
        }

        string result = string.Join(string.Empty, array);

        Console.WriteLine("\nResult is {0} -> {1}\n{2}\n", num, result, new string('-', 40));
    }

    public static void AverageOfSequence()
    {
        Console.WriteLine("\n{0}", new string('-', 40));

        int n = 0;
        do
        {
            Console.Write("Enter a non - negativ number (size of array):");
            n = int.Parse(Console.ReadLine());

        }
        while (n <= 0);

        int[] number = new int[n];
        Console.WriteLine("\nEnter a {0} element of array: ", n);
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write("     {0}: ", i + 1);
            number[i] = int.Parse(Console.ReadLine());
        }

        decimal result = 0;

        for (int i = 0; i < number.Length; i++)
        {
            result += number[i];
        }

        result = result / number.Length;

        Console.WriteLine("\nAverage Sum = {0}\n{1}\n", result, new string('-', 40));
    }

    public static void LinearEquation()
    {
        Console.WriteLine("\n{0}", new string('-', 40));

        decimal a = 0;

        do
        {
            Console.Write("Enter a non - zero number A:");
            a = decimal.Parse(Console.ReadLine());

        }
        while (a == 0);

        Console.Write("Enter a non - zero number B:");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nResult -> x = -b / a = {0}\n{1}\n", -b / a, new string('-', 40));
    }

    public static void Main()
    {
        Console.WriteLine("Program options: ");
        Console.WriteLine("     1) Reverses the digits of a number:");
        Console.WriteLine("     2) Calculates the average of a sequence of integers:");
        Console.WriteLine("     3) Solves a linear equation (a * x + b = 0):");
        Console.Write("\nEnter your choice:");

        int choice = int.Parse(Console.ReadLine());

        while (choice < 1 || choice > 3)
        {
            Console.WriteLine("\n{0}", new string('-', 40));
            Console.Write("Invalid number. Enter number in 1-3:");
            choice = int.Parse(Console.ReadLine());
        }

        switch (choice)
        {
            case 1: ReversNumber(); return;
            case 2: AverageOfSequence(); return;
            case 3: LinearEquation(); return;
            default: break;
        }
    }
}
