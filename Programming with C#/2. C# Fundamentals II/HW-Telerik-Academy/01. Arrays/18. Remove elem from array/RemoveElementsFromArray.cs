/*Problem 18.* Remove elements from array
Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
Print the remaining sorted array.
Example:
| input	                        | result
| 6, 1, 4, 3, 0, 3, 6, 4, 5	    | 1, 3, 3, 4, 5
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class RemoveElementsFromArray
{
    static List<int>[] allBestSubsets = new List<int>[40];
    static int index = 0;

    static void Main()
    {
        Console.Title = "Problem 18.* Remove elements from array";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 18.* Remove elements from array!");
        PrintSeparateLine();

        Console.Write("Enter the size of the array: n = ");
        int n = int.Parse(Console.ReadLine());

        PrintSeparateLine();

        int[] array = new int[n];
        Console.WriteLine("Enter the elements of array:\n");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" arr[{0}] --> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        PrintSeparateLine();
        
        // finnd the lognest(s) sort subset
        FindAllSubsets(array);
        PrintLongestSubsets(array);
        PrintSeparateLine();

        // TEST METHOD
        // TestRunner();
    }

    // Find all subsets using BITWISE REPRESENTATION
    static void FindAllSubsets(int[] array)
    {
        List<int> subset = new List<int>();
        long bestLength = 0;
        int n = array.Length;

        // max combinations of subsets
        long allSubsets = (long)(Math.Pow(2, n) - 1);

        for (long i = allSubsets; i >= 1; i--)
        {
            long elementInSubset = ElementsInSubset(i);

            if (elementInSubset < bestLength)
            {
                continue;
            }

            subset.Clear();

            for (int j = 0; j < array.Length; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    subset.Add(array[j]);
                }
            }

            if (IsIncreasingElements(subset))
            {
                if (bestLength < elementInSubset)
                {
                    allBestSubsets = new List<int>[40];
                    index = 0;
                }

                bestLength = elementInSubset;

                allBestSubsets[index++] = new List<int>(subset);
            }
        }
    }

    // Optimization method
    static long ElementsInSubset(long currentNumber)
    {
        long elementsInSubset = 0;

        while (currentNumber != 0)
        {
            elementsInSubset += currentNumber & 1;
            currentNumber >>= 1;
        }

        return elementsInSubset;
    }

    static bool IsIncreasingElements(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    static void PrintLongestSubsets(int[] numbers)
    {
        Console.WriteLine("Test array's elements: {0, 3}", string.Join(" ", numbers));

        Console.WriteLine("\nLongest subset(s) with increasing elements: ");
        for (int i = 0; i < index; i++)
        {
            foreach (var arr in allBestSubsets[i])
            {
                Console.Write("{0, 3}", arr);
            }

            Console.WriteLine();
        }  
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

        int[] test0 = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        FindAllSubsets(test0);
        PrintLongestSubsets(test0);
        PrintSeparateLine();

        int[] test1 = { 1, 1, 1, 1, 1, 1 };
        FindAllSubsets(test1);
        PrintLongestSubsets(test1);
        PrintSeparateLine();

        int[] test2 = { 1, -5, 2, -4, 3, -3, 4, -2, 5, -1 };
       FindAllSubsets(test2);
        PrintLongestSubsets(test2);
        PrintSeparateLine();
    }
}