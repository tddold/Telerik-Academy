/*Problem 4. Number Comparer
Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Title = "Number Compare";

        Console.WriteLine("Enter two number to compare:");
        Console.Write("a --> ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b --> ");
        double b = double.Parse(Console.ReadLine());

        double greater = Math.Max(a, b);

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("a = {0} | b = {1} | greater = {2}", a, b, greater);
        Console.WriteLine(new string('-', 40));
    }
}