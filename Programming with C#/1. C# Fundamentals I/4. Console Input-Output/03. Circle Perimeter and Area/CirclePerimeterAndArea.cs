/*Problem 3. Circle Perimeter and Area
Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Title = "Circle Perimeter and Area";

        Console.Write("Enter circle radius: ");
        float r = float.Parse(Console.ReadLine());

        float area = (float) Math.PI * r * r;
        float perimeter = 2 * (float) Math.PI * r;

        Console.WriteLine(new string('-', 60));
        Console.WriteLine("r = {0} | perimeter = {1:0.00} | area = {2:0.00}", r, perimeter, area);
        Console.WriteLine(new string('-', 60));
    }
}