/*Problem 5. The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers.*/

using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Title = "The Biggest of 3 Numbers";

        Console.WriteLine("Enter three number:");
        Console.Write("a --> ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b --> ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c --> ");
        double c = double.Parse(Console.ReadLine());
        
        double biggest = 0;

        if (a > b)
        {
            biggest = a;

            if (c > biggest)
            {
                biggest = c;

            }
        }
        else
        {
            biggest = b;

            if (c > biggest)
            {
                biggest = c;
            }
        }

        Console.WriteLine("Result --> {0}", biggest);
    }
}