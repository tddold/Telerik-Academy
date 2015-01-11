/*Problem 11.* Numbers in Interval Dividable by Given Number
Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.*/

using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Title = "Numbers in Interval Dividable by Given Number";

        Console.WriteLine("Numbers in Interval Dividable by Given Number!");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter positive integer numbers a: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter positive integer numbers b: ");
        int end = int.Parse(Console.ReadLine());

        int result = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                result++;
            }
        }

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Result is: {0}", result);
        Console.WriteLine(new string('-', 40));
    }
}