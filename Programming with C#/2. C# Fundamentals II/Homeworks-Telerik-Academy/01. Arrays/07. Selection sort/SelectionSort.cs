/*Problem 7. Selection sort
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

class SelectionSort
{
    // EASE OF USE: The program contains test method that show us how the program work on diffent inputs
    // The method that tests the program is called "TestRunner"
    static void Main()
    {
        Console.Title = "Problem 7. Selection sort";

        // setting culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 7. Selection sort!");
        PrintSeparateLine();

        Console.Write("\nEnter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());
        PrintSeparateLine();

        // input array elements
        int[] array = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array", n);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }


        // print input array
        PrintSeparateLine();
        Console.Write("Print input array :");
        PrintArray(array);                          //             <--  using print metod - using for loops

        // Classical implementation of Selection Sort Algorithm
        SelectionSortAlgorithm(array);
        Console.Write("Print sorted array:");
        Console.WriteLine(string.Join(" ", array)); //             <-- using string.Join()
        PrintSeparateLine();

        // TEST METHOD
        // TestRunner();
    }

    static int[] SelectionSortAlgorithm(int[] array)
    {
        int index, swap;

        for (int i = 0; i < array.Length - 1; i++)
        {
            index = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[index] > array[j])
                {                   
                    index = j;
                }
            }
            swap = Swap(array, index, i);
        }

        return array;
    }

    private static int Swap(int[] array, int index, int i)
    {
        int swap;
        swap = array[index];
        array[index] = array[i];
        array[i] = swap;
        return swap;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i <= array.Length - 2)
            {
                Console.Write("{0} ", array[i]);
            }
            else
            {
                Console.Write("{0}", array[i]);
            }
        }

        Console.WriteLine();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void TestRunner()
    {       
        Console.Write(new string('*', 24));
        Console.Write("TestRunner");
        Console.WriteLine(new string('*', 24));

        int[] test0 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        PrintArray(test0);
        PrintArray(SelectionSortAlgorithm(test0));
        PrintSeparateLine();

        int[] test1 = { 900, 800, 700, 600, 500, 400, 300, 200, 100 };
        PrintArray(test1);
        PrintArray(SelectionSortAlgorithm(test1));
        PrintSeparateLine();
    }
}