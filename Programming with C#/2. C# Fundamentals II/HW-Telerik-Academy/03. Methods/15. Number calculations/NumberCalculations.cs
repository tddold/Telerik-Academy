/*Problem 15.* Number calculations
Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
Use generic method (read in Internet about generic methods in C#).*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class NumberCalculations
{
    static void Main()
    {
        Console.Title = "Problem 15.* Number calculations";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 15.* Number calculations!");
        PrintSeparateLine();

        Console.WriteLine("The Minimum of set integers: {0}", GetMin(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Maximum of set integers: {0}", GetMax(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Average Sum of set integers: {0}", GetAverageSum(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Sum of set integers: {0}", GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Product of set integers: {0}\n", GetProduct(1, 2, 3, 4, 5, 6, 7, 8, 9));

        PrintSeparateLine();
    }

    static T GetMin<T>(params T[] sequence)
    {
        dynamic min = sequence[0];

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] < min)
            {
                min = sequence[i];
            }
        }

        return min;
    }

    static T GetMax<T>(params T[] sequence)
    {
        dynamic max = sequence[0];

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] >= max)
            {
                max = sequence[i];
            }
        }

        return max;
    }

    static T GetAverageSum<T>(params T[] sequence)
    {
        dynamic averageSum = 0;
        int i = 0;

        for (i = 0; i < sequence.Length; i++)
        {
            averageSum += sequence[i];
        }

        return averageSum / i;
    }

    static T GetSum<T>(params T[] sequence)
    {
        dynamic sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum;
    }

    static T GetProduct<T>(params T[] sequence)
    {
        dynamic prodact = 1;
        for (int i = 0; i < sequence.Length; i++)
        {
            prodact *= sequence[i];
        }

        return prodact;
    }

   static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}