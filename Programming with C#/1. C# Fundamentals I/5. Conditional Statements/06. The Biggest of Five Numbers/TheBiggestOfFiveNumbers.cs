/*Problem 6. The Biggest of Five Numbers
Write a program that finds the biggest of five numbers by using only five if statements.*/

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Title = "The Biggest of Five Numbers";

        Console.WriteLine("Enter five number:");
        Console.Write("a --> ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b --> ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c --> ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d --> ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e --> ");
        double e = double.Parse(Console.ReadLine());
        double biggest = 0;

        if (a > b)
        {
            biggest = a;

            if (c > biggest)
            {
                biggest = c;

            }

            if (d > biggest)
            {
                biggest = d;
            }

            if (e > biggest)
            {
                biggest = e;
            }
        }
        else
        {
            biggest = b;

            if (c > biggest)
            {
                biggest = c;
            }

            if (d > biggest)
            {
                biggest = d;
            }

            if (e > biggest)
            {
                biggest = e;
            }
        }

        Console.WriteLine("Result --> {0}", biggest);
    }
}