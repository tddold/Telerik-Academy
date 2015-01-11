/*Problem 8. Numbers from 1 to n
Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.*/

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Title = "Numbers from 1 to N";

        Console.WriteLine("Numbers from 1 to N!");
        Console.WriteLine(new string('-', 40));
        Console.Write("Input integer number: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.Write("Invalid number! Input number > 1: ");
        }

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}