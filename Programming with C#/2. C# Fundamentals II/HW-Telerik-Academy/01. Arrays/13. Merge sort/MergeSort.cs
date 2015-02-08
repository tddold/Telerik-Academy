/*Problem 13.* Merge sort
Write a program that sorts an array of integers using the Merge sort algorithm.*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class MergeSort
{
    static void Main()
    {
        Console.Title = "Problem 13.* Merge sort";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 13.* Merge sort!");
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
        MergeSortMethod(array);

        Console.Write("After sorting : ");
        PrintArray(array);
        PrintSeparateLine();
    }

    static void MergeSortMethod(int[] array)
    {
        int n = array.Length;

        int l = n / 2;
        int r = n - l;

        int[] leftArray = new int[l];
        int[] rightArray = new int[r];

        // bottom of recursion
        if (n < 2)
        {
            return;
        }

        // create left array
        for (int i = 0; i < l; i++)
        {
            leftArray[i] = array[i];
        }

        // create right array
        for (int i = l; i < n; i++)
        {
            rightArray[i - l] = array[i];
        }

        // recursion
        MergeSortMethod(leftArray);
        MergeSortMethod(rightArray);

        // merge both array
        Merge(leftArray, rightArray, array);
    }

    static int[] Merge(int[] leftArray, int[] rightArray, int[] array)
    {
        int n = 0, l = 0, r = 0;

        while (l < leftArray.Length && r < rightArray.Length)
        {
            if (leftArray[l] < rightArray[r])
            {
                array[n] = leftArray[l];
                l++;
                n++;
            }
            else
            {
                array[n] = rightArray[r];
                r++;
                n++;
            }
        }

        while (l < leftArray.Length)
        {
            array[n++] = leftArray[l++];
        }

        while (r < rightArray.Length)
        {
            array[n++] = rightArray[r++];
        }

        return array;
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