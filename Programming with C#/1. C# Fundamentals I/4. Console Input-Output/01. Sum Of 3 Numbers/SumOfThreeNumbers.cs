/*Problem 1. Sum of 3 Numbers
Write a program that reads 3 real numbers from the console and prints their sum.*/

using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Title = "Sum of 3 Numbers";

        Console.WriteLine("Read three real numbers from console.");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter real number a:");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter real number b:");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter real number c:");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 60));
        Console.WriteLine("Print sum  a + b + c --> {0} + {1} + {2} = {3}", a, b, c, (a + b + c));
        Console.WriteLine(new string('-', 60));
    }
}