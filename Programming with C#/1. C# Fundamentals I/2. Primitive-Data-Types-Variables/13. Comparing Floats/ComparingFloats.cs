/*Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Title = "Comparing Floats";

        Console.WriteLine("Enter a and b real number:");
        Console.WriteLine(new string('-', 40));
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;                              // this is precision for compares
        double difference = Math.Abs(a - b);

        if (difference <= eps)
        {
            Console.WriteLine("Real numbers a and b are equal.");
        }
        else
        {
            Console.WriteLine("Real numbers a and b are unequal.");
        }
    }
}