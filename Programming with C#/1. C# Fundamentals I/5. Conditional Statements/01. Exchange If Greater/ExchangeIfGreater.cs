/*Problem 1. Exchange If Greater
Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.*/

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Title = "Exchange If Greater";

        Console.WriteLine("Enter two double variables: ");
        Console.WriteLine(new string('-', 40));
        Console.Write("First variable a is  --> ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Second variable b is --> ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(new string('-', 40));

        if (a > b)
        {
            Console.WriteLine("Result: {0} {1}", b, a);
        }
        else
        {
            Console.WriteLine("Result: {0} {1}", a, b);
        }

        Console.WriteLine(new string('-', 40));
    }
}