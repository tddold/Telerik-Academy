/*Problem 7. Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).*/

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Title = "Point in a Circle";

        Console.WriteLine("Enter two numbers coordinates of a point:");
        Console.Write("X --> ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Y --> ");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 40));
        Console.Write("Point is in the circle! --> ");

        if (((x * x) + (y * y)) <= (2 * 2))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}