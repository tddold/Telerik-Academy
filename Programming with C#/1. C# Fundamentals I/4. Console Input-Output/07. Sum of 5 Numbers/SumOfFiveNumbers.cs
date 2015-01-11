/*Problem 7. Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.*/

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Title = "Sum of 5 Numbers";

        Console.WriteLine("Sum of 5 numbers!");
        Console.WriteLine(new string('-', 40));
        Console.Write("Input five numbers (separated by a space): ");
        string[] numbers = Console.ReadLine().Split(' ');
        double sumOfNumbers = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sumOfNumbers += double.Parse(numbers[i]);
        }

        Console.WriteLine("\nSum of all numbers: {0}\n", sumOfNumbers);
    }
}