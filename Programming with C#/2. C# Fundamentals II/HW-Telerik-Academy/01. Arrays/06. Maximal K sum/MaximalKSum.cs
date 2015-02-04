﻿/*Problem 6. Maximal K sum
Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

class MaxIncreasingSequence
{
    // EASE OF USE: The program contains test method that show us how the program work on diffent inputs
    // The method that tests the program is called "TestRunner"

    static void Main()
    {
        Console.Title = "Problem 6. Maximal K sum!";

        // setting for culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine(" Maximal K sum!");
        PrintSeparateLine();                                        // print separate line with '-'

        Console.Write("Enter size of array (N): ");
        int arrayLenght = int.Parse(Console.ReadLine());

        Console.Write("Enter a number of elements in subset (K): ");
        int subsetLenght = int.Parse(Console.ReadLine());

        // check subsetArray > array
        PrintSeparateLine();
        if (subsetLenght > arrayLenght)
        {
            Console.WriteLine("Number of elements mast bu smaller or equal\nto size in array!\n");
            return;
        }

        // input numbers in array
        int[] array = new int[arrayLenght];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" {0} number to array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        // print output
        PrintSeparateLine();

        // Solution without using Array>Sort()
        Console.WriteLine("Solution without using Array>Sort()");
        PrintSubsetArray(array, FindSubsetWithMaxSunWithoutSort(array, subsetLenght));

        // Solution with using Array>Sort()
        Console.WriteLine("Solution with using Array>Sort()");
        PrintSubsetArray(array, FindSubsetWithMaxSum(array, subsetLenght));

        // TEST METHOD
        // to run test remove coments before TestRunner 
        // TestRunner();
    }

    static List<int> FindSubsetWithMaxSunWithoutSort(int[] array, int k)
    {
        List<int> subsetArray = new List<int>();

        // sort array
        for (int i = 0; i < array.Length; i++)
        {
            int maxElement = array[i];
            for (int j = i + 1; j <= array.Length - 1; j++)
            {
                if (array[i] < array[j])
                {
                    maxElement = array[j];
                    array[j] = array[i];
                    array[i] = maxElement;
                }
            }
        }

        // get subsetArray
        for (int i = 0; i < k; i++)
        {
            subsetArray.Add(array[i]);
        }

        return subsetArray;
    }

    static List<int> FindSubsetWithMaxSum(int[] array, int subsetLenght)
    {
        List<int> subsetArray = new List<int>();
        Array.Sort(array);

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (subsetLenght > 0)
            {
                subsetArray.Add(array[i]);
                subsetLenght--;
            }
        }

        return subsetArray;
    }

    static void PrintSubsetArray(int[] array, List<int> subsetArray)
    {
        Console.WriteLine("\n Elements of input array: {0}", string.Join(" ", array));
        Console.WriteLine(" Subsequence with {0} elements", subsetArray.Count);
        Console.WriteLine(" Maximal SUm: {0}", subsetArray.Sum());
        Console.WriteLine(" Subset with maximal sum: {0}", string.Join(" ", subsetArray));
        PrintSeparateLine();
    }

    private static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void TestRunner()
    {
        Console.Write(new string('*', 24));
        Console.Write("Test Runner!");
        Console.WriteLine(new string('*', 24));
        PrintSeparateLine();

        int[] test0 = { 8, 1, 3, 5, 7, 9, 8 };
        int subsetLenght = 3;
        PrintSubsetArray(test0, FindSubsetWithMaxSum(test0, subsetLenght));

        int[] test1 = { 1 };
        subsetLenght = 0;
        PrintSubsetArray(test1, FindSubsetWithMaxSum(test1, subsetLenght));

        int[] test2 = { 1, 2, 3, 4, 1 };
        subsetLenght = 2;
        PrintSubsetArray(test2, FindSubsetWithMaxSum(test2, subsetLenght));

        int[] test3 = { 6, 1, 6, 6, 5 };
        subsetLenght = 3;
        PrintSubsetArray(test3, FindSubsetWithMaxSum(test3, subsetLenght));

        int[] test4 = { 6, 5, 4, 3, 2, 1 };
        subsetLenght = 1;
        PrintSubsetArray(test4, FindSubsetWithMaxSum(test4, subsetLenght));

        int[] test5 = { 1, 2, 3, 4, 9 };
        subsetLenght = 0;
        PrintSubsetArray(test5, FindSubsetWithMaxSum(test5, subsetLenght));

        int[] test6 = { 1, 2, 3, 7, 1, 2, 3, 4, 8 };
        subsetLenght = 3;
        PrintSubsetArray(test6, FindSubsetWithMaxSum(test6, subsetLenght));

        int[] test7 = { 2, 4, 6, 1, 2, 3, 4, 1, 3, 5, 7, 9 };
        subsetLenght = 3;
        PrintSubsetArray(test7, FindSubsetWithMaxSum(test7, subsetLenght));

        int[] test8 = { 1, 1, 2, 2, 2, 3, 4, 5 };
        subsetLenght = 3;
        PrintSubsetArray(test8, FindSubsetWithMaxSum(test8, subsetLenght));

        Console.WriteLine();
        // PrintSeparateLine();
    }
}