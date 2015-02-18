/*Problem 14. Integer calculations
Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.Problem 14. Integer calculations
 */

using System;
using System.Globalization;
using System.Threading;

class IntegerCalculations
{
    static void Main()
    {
        Console.Title = "Problem 14. Integer calculations";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 14. Integer calculations!");
        PrintSeparateLine();

        Console.WriteLine("The Minimum of set integers: {0}", GetMin(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Maximum of set integers: {0}", GetMax(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Average Sum of set integers: {0}", GetAverageSum(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Sum of set integers: {0}", GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Product of set integers: {0}\n", GetProduct(1, 2, 3, 4, 5, 6, 7, 8, 9));

        PrintSeparateLine();
    }

    static int GetMin(params int[] sequence)
    {
        int min = int.MaxValue, i;

        for (i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] < min)
            {
                min = sequence[i];
            }
        }
        return min;
    }

    static int GetMax(params int[] sequence)
    {
        int max = int.MinValue, i;

        for (i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] >= max)
            {
                max = sequence[i];
            }
        }
        return max;
    }

    static int GetAverageSum(params int[] sequence)
    {
        int averageSum = 0, i;
        for (i = 0; i < sequence.Length; i++)
        {
            averageSum += sequence[i];
        }

        return averageSum / i;
    }

    static int GetSum(params int[] sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum;
    }

    static int GetProduct(params int[] sequence)
    {
        int prodact = 1;
        for (int i = 0; i < sequence.Length; i++)
        {
            prodact *= sequence[i];
        }

        return prodact;
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}