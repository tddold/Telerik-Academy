/*Problem 17.* Subset K with sum S
Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
Find in the array a subset of K elements that have sum S or indicate about its absence.*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Title = "Problem 17.* Subset K with sum S";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 17.* Subset K with sum S!");
        PrintSeparateLine();

        Console.Write("Enter the size of the array: n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of sum: s = ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Enter the lenght of subset array: k = ");
        int k = int.Parse(Console.ReadLine());

        PrintSeparateLine();

        int[] array = new int[n];
        Console.WriteLine("Enter the elements of array:\n");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" arr[{0}] --> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        PrintSeparateLine();
        Console.WriteLine("Test array: {0}\n", string.Join(" ", array));

        // finnd subset with sum s
        SubsetWithSum(array, s, k);

        PrintSeparateLine();

        // TEST METHOD
        // TestRunner(s, k);
    }

    static void SubsetWithSum(int[] array, int s, int k)
    {
        int n = array.Length;
        int subsetCombination = (int) Math.Pow(2, n);
        bool isTrue = false;
        bool isPrint = false;

        List<int> subset = new List<int>();

        for (int i = 0; i < subsetCombination; i++)
        {
            isTrue = false;
            subset.Clear();

            for (int j = 0; j < n; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    subset.Add(array[j]);
                }
            }

            if (subset.Sum() == s && subset.Count == k)
            {
                isTrue = true;
                isPrint = true;
                PrintArray(subset, s, k, isTrue);
            }
        }

        if (!isPrint && !isTrue)
        {
            PrintArray(subset, s, k, isTrue);
        }
    }

    static void PrintArray(List<int> subset, int s, int k, bool isTrue)
    {
        if (!isTrue)
        {
            Console.WriteLine("Not subset array with sum(s) = {0} and lenght(k) = {1}!", s, k);
        }
        else
        {
            Console.WriteLine("Subset array with sum(s) = {0} and lenght(k) = {1} is --> {2}", s, k, string.Join(" ", subset));
        }
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void TestRunner(int s, int k)
    {
        Console.Write(new string('*', 24));
        Console.Write("TestRunner");
        Console.WriteLine(new string('*', 24));

        int[] test0 = { 2, 1, 2, 4, 3, 5, 2, 6 };
        s = 6;
        k = 3;
        Console.WriteLine("Test array: {0}\n", string.Join(" ", test0));
        SubsetWithSum(test0, s, k);
        PrintSeparateLine();

        int[] test1 = { 1, 1, 1, 1, 1, 1 };
        s = 6;
        k = 1;
        Console.WriteLine("Test array: {0}\n", string.Join(" ", test1));
        SubsetWithSum(test1, s, k);
        PrintSeparateLine();
    }
}
