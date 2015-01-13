/*Problem 18.* Trailing Zeroes in N!
Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.*/

using System;
using System.Numerics;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        Console.Title = "Trailing Zeroes in N!";

        // # First method - it is very slow
        // --------------------------------

        // input
        Console.WriteLine("Enter number");
        Console.WriteLine(new string('-', 40));        
        Console.Write("n  --> ");
        int n = int.Parse(Console.ReadLine());

        BigInteger nFactorel = 1;
        nFactorel = GetNFactorial(n, nFactorel);

        Console.WriteLine("n! --> {0}", nFactorel);
        Console.WriteLine(new string('_', 80));

        // logic        
        int countZero = 0;       
        while (nFactorel % 10 == 0)
        {
            nFactorel = nFactorel / 10;
            countZero++;
        }
        // output
        Console.WriteLine("First method: {0}", countZero);

        // # Second method - it is very fast
        // ---------------------------------
        int factorFive = 5;
        int dividParameter = 0;
        int count = 1;
        countZero = 0;

        for (int i = 0; i < n; i++)
        {
            dividParameter = (int) Math.Pow(factorFive, count);
            countZero += n / dividParameter;
            count++;
        }

        Console.WriteLine("Second method: {0}", countZero);
    }

    private static BigInteger GetNFactorial(int n, BigInteger nFactorel)
    {
        for (int i = 1; i <= n; i++)
        {
            nFactorel *= i;
        }

        return nFactorel;
    }
}