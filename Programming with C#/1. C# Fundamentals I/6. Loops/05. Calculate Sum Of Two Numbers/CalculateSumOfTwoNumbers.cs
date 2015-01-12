/*Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;

class CalculateSumOfTwoNumbers
{
    static void Main()
    {
        Console.Title = "Calculate 1 + 1!/X + 2!/X2 + … + N!/XN";

        Console.WriteLine("Enter two numbers:");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter x --> ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter n --> ");
        int x = int.Parse(Console.ReadLine());
        int nFacturel = 1;
        double xPower = 1;
        double sum = 1;
        int counter = 1;

        while (counter <= n)
        {
            nFacturel *= counter;
            xPower = Math.Pow(x, counter);
            sum += (nFacturel / xPower);
            counter++;
        }

        Console.WriteLine("S = {0:0.00000}", sum);
    }
}