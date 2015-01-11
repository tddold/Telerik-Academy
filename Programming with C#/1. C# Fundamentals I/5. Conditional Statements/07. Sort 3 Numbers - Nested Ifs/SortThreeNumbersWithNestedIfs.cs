/*Problem 7. Sort 3 Numbers with Nested Ifs
Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.*/

using System;

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.Title = "Sort 3 Numbers with Nested Ifs";

        Console.WriteLine("Enter three number:");
        Console.Write("a --> ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b --> ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c --> ");
        double c = double.Parse(Console.ReadLine());
        double tmp = 0;

        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("Result --> {0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("Result --> {0} {1} {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("Result --> {0} {1} {2}", c, a, b);
            }
        }
        else
        {
            if (b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("Result --> {0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("Result --> {0} {1} {2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("Result --> {0} {1} {2}", c, b, a);
            }
        }
    }
}