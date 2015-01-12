/*Problem 6. Calculate N! / K!
Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.*/

using System;

class Program
{
    static void Main()
    {
        Console.Title = "Calculate N! / K!";

        Console.WriteLine("Enter two numbers:");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter n --> ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter n --> ");
        int k = int.Parse(Console.ReadLine());
        int nFacturelN = 1;
        int nFacturelK = 1;
        int div = 1;
        int counter = 1;

        while (counter <= n)
        {
            nFacturelN *= counter;
            if (counter <= k)
            {
                nFacturelK *= counter;
            }

            div = (nFacturelN / nFacturelK);
            counter++;
        }

        Console.WriteLine("n!/k! = {0}", div);
    }
}