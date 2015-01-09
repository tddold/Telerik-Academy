/*Problem 9. Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Title = "Trapezoids";

        Console.WriteLine("Enter the sides and the height of the trapezoid.");
        Console.Write("Side a --> ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Side b --> ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Height h --> ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The trapecoid's area is --> " + ((a + b) * h) / 2);
    }
}