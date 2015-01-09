/*Problem 2. Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Title = "Gravitation on the Moon";

        Console.Write("Enter your weight on the Earth: ");
        double weight = double.Parse(Console.ReadLine());
        double weightMoon = weight * (double)17 / 100;

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Your weight on the Moon is: {0}kg", weightMoon);
    }
}