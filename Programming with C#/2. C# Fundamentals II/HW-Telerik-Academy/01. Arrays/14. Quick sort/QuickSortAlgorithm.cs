/*Problem 14. Quick sort
Write a program that sorts an array of strings using the Quick sort algorithm.*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class QuickSortAlgorithm
{
    static void Main()
    {
        Console.Title = "Problem 14. Quick sort";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 14. Quick sort!");
        PrintSeparateLine();

        Console.Write("Enter the size of the array: ");
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

        Console.Write("Before sorting: ");
        PrintArray(array);
        PrintSeparateLine();

        // sort array using Merge Sort Algorithm
        QuickSort(array, 0, array.Length-1);

        Console.Write("After sorting : ");
        PrintArray(array);
        PrintSeparateLine();

    }

    static void QuickSort(int[] array, int start, int end)
    {
        if (start < end)
        {
            // calling partition
            int partitionIndex = Partition(array, start, end);

            // calling recursion
            QuickSort(array, start, partitionIndex-1);
            QuickSort(array, partitionIndex+1, end);
        }
    }

    static int Partition(int[] array, int start, int end)
    {
        int pivot = array[end];

        // set partition index as satart initially
        int partitionIndex = start;

        for (int i = start; i < end; i++)
        {
            if (array[i] <= pivot)
            {
                // swap if element is lesser than pivot
                Swap(array, i, partitionIndex);
                partitionIndex++;
            }
            
        }

        // swap pivot with element at partition index
        Swap(array, partitionIndex, end);
        return partitionIndex;
    }

    static void Swap(int[] array, int i, int j)
    {
        int tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}