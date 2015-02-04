/*Problem 8. Maximal sum
Write a program that finds the sequence of maximal sum in given array.
Example:
| input	                                | result
| 2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    | 2, -1, 6, 4
Can you do it with only one loop (with single scan through the elements of the array)?*/

using System;
using System.Globalization;
using System.Threading;

class MaximalSum
{
    // EASE OF USE: The program contains test method that show us how the program work on diffent inputs
    // The method that tests the program is called "TestRunner"

    // Not works if all elements in array are negative!!!

    static int maxSum = 0, maxStart = 0, maxEnd = 0;
    static void Main()
    {
        Console.Title = "Problem 8. Maximal sum";

        // setting culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 8. Maximal sum!");
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

        // Print input array
        Console.Write("\nElements on input array are : ");
        Console.WriteLine(string.Join(" ", array));

        FindMaxSequence(array);
        PrintMaxSequence(array, maxStart, maxEnd, maxSum);
        PrintSeparateLine();

        // TEST METHOD
        // TestRunner();

    }

    static void FindMaxSequence(int[] array)
    {
        maxStart = 0;
        maxEnd = 0;
        maxSum = 0;
        int endIndex, currrSum;
        int startIndex = 0;

        currrSum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (currrSum <= 0)
            {
                currrSum = 0;
                startIndex = i;
            }

            currrSum += array[i];
            endIndex = i;

            if (currrSum > maxSum)
            {
                maxSum = currrSum;
                maxStart = startIndex;
                maxEnd = i;
            }
        }
    }

    static void PrintMaxSequence(int[] array, int maxStart, int maxEnd, int maxSum)
    {
        Console.Write("\nElements on output array are: ");
        for (int i = maxStart; i <= maxEnd; i++)
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
        Console.WriteLine("Maximal sum: {0}", maxSum);
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

        int[] test0 = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        FindMaxSequence(test0);
        PrintMaxSequence(test0, maxStart, maxEnd, maxSum);
        PrintSeparateLine();

        int[] test1 = { 1, 2, 3, 4, 5, 6 };
        FindMaxSequence(test1);
        PrintMaxSequence(test1, maxStart, maxEnd, maxSum);
        PrintSeparateLine();

        int[] test2 = { 1, 2, -3, 1, 2, 3, 4, -4, 3 };
        FindMaxSequence(test2);
        PrintMaxSequence(test2, maxStart, maxEnd, maxSum);
        PrintSeparateLine();

        int[] test3 = { -6, 2, 6, -2, 1, -7, 5, 2, -1, 4, -5, -6, 2, -1 };
        FindMaxSequence(test3);
        PrintMaxSequence(test3, maxStart, maxEnd, maxSum);
        PrintSeparateLine();
    }
}