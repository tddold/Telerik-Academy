/*Problem 8. Catalan Numbers
In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (1 < n < 100).*/

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Title = "Catalan Numbers";

        Console.WriteLine("Enter number:");
        Console.WriteLine(new string('-', 40));
        Console.Write("n --> ");
        int n = int.Parse(Console.ReadLine());

        BigInteger nFacturelN = 1;
        BigInteger nFacturel2N = 1;
        BigInteger sumFacturiel = 1;
        BigInteger catlanNumbers = 1;
        int counter = 1;

        while (counter <= n)
        {
            nFacturelN *= counter;
            counter++;
        }

        counter = 1;
        while (counter <= (n + 1))
        {
            sumFacturiel *= counter;
            counter++;
        }

        counter = 1;
        while (counter <= (2 * n))
        {
            nFacturel2N *= counter;
            counter++;
        }

        catlanNumbers = (nFacturel2N / (nFacturelN * sumFacturiel));

        Console.WriteLine("(2n)!/(n+1)!*n! = {0}", catlanNumbers);
    }
}