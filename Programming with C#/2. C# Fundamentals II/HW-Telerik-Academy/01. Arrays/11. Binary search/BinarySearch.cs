/*Problem 11. Binary search
Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
  int[] array = { 8, 5, 6, 9, 22, 2, 4, 7, 11, 15, 1, 19, 10 };*/

using System;
using System.Linq;
using System.Globalization;
using System.Threading;

class BinarySearch
{
    // EASE OF USE: The program contains test method that show us how the program work on diffent inputs
    // The method that tests the program is called "TestRunner"
    static void Main()
    {
        Console.Title = "Problem 11. Binary search";

        // setting culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 11. Binary search!");
        PrintSeparateLine();

        Console.Write("\nEnter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());
        PrintSeparateLine();

        Console.Write("\nEnter searched number: ");
        int searchNumber = int.Parse(Console.ReadLine());
        PrintSeparateLine();

        // input array elements
        int[] array = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array", n);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" arr[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Print input array
        Console.Write("\nElements on input array are : ");
        PrintInputArray(array);
        PrintSeparateLine();

        // sort array
        Array.Sort(array);

        // print sort array
        Console.Write("\nPrint sort array are : ");
        PrintInputArray(array);
        PrintSeparateLine();

        // get number
        int index = GetNumberUsingBinarySearch(array, searchNumber);

        // print output
        PrintResult(searchNumber, index);
        PrintSeparateLine();

        // TEST METHOD
        // TestRunner();
    }

    private static void PrintResult(int searchNumber, int index)
    {
        if (index != -1)
        {
            Console.WriteLine("\nNumber {0} found at index: {1}\n", searchNumber, index);
        }
        else
        {
            Console.WriteLine("\nNumber {0} not found!\n", searchNumber);
        }
    }

    private static int GetNumberUsingBinarySearch(int[] array, int searchNumber)
    {
        int low = 0, high = array.Length - 1, midArray = 0;

        while (low <= high)
        {
            midArray = low + (high - low) / 2;

            if (array[midArray] == searchNumber)
            {
                return midArray;
            }
            if (array[midArray] < searchNumber)
            {
                low = midArray + 1;
            }
            else
            {
                high = midArray - 1;
            }

        }

        return -1; // Not found
    }

    private static void PrintInputArray(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine();
    }

    private static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    private static void TestRunner()
    {
        Console.Write(new string('*', 24));
        Console.Write("TestRunner");
        Console.WriteLine(new string('*', 24));

        int[] test0 = { 8, 5, 6, 9, 22, 2, 4, 7, 11, 15, 1, 19, 10 };
        int searchNumber = 4;

        PrintInputArray(test0);
        PrintSeparateLine();

        Array.Sort(test0);

        PrintInputArray(test0);
        PrintSeparateLine();

        int index = GetNumberUsingBinarySearch(test0, searchNumber);
        PrintResult(searchNumber, index);
        PrintSeparateLine();

    }
}