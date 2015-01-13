/*Problem 17.* Calculate GCD
Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).*/

using System;

class CalculateGCD
{
    static void Main(string[] args)
    {
        Console.Title = "Calculate GCD";

        // input
        Console.WriteLine("Enter two numbers:");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter a --> ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b --> ");
        int b = int.Parse(Console.ReadLine());

        // logic
        int gcdNumber = 0;
        int remander;

        if (a > b)
        {
            while (b > 0)
            {
                remander = a % b;
                a = b;
                b = remander;
            }

            gcdNumber = a;
        }
        else
        {
            // int remander;
            while (a > 0)
            {
                remander = b % a;
                b = a;
                a = remander;
            }

            gcdNumber = b;
        }

        // output
        Console.WriteLine(gcdNumber);
    }
}