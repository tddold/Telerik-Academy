/*Problem 9. Sorting array
Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.*/

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.Title = "Problem 9. Sorting array";

        Console.WriteLine("Problem 9. Sorting array!");
        PrintSeparateLine();

        Console.Write("Enter lenght of array: ");
        int lenght = int.Parse(Console.ReadLine());

        PrintSeparateLine();

        int[] array = new int[lenght];

        Console.WriteLine("Enter lements of array:\n");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" arr[{0}] -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        PrintSeparateLine();

        Console.Write("\nEnter start index: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());

        PrintSeparateLine();

        Console.WriteLine("\nMax element in partition of array [{0}, {1}] -> {2}", start, end, FindMaxElementInPartitionOfArray(array, start, end));

        Console.WriteLine("\nNumbers in Ascending order : {0}", string.Join(" ", SortAscending(array)));

        Console.WriteLine("Numbers in Descending order: {0}\n", string.Join(" ", SortDescending(array)));

        PrintSeparateLine();
       
    }

    static int FindMaxElementInPartitionOfArray(int[] array, int start, int end, int index = 0)
    {
        int maxIndex = start;

        for (int i = start; i <= end; i++)
        {
            if (array[maxIndex] < array[i])
            {
                maxIndex = i;
            }
        }

        int maxElement = Swap(array, index, maxIndex);

        return maxElement;
    }

    static int Swap(int[] array, int index, int maxIndex)
    {
        int tmp = array[index];
        array[index] = array[maxIndex];
        array[maxIndex] = tmp;

        return array[index];
    }

    static int[] SortAscending(int[] array)
    {
        int[] sortedArray = new int[array.Length];

        for (int i = sortedArray.Length - 1; i >= 0; i--)
        {
            sortedArray[i] = FindMaxElementInPartitionOfArray(array, 0, i, i);
;
        }

        return sortedArray;  
    }

    static int[] SortDescending(int[] array)
    {
        int[] sortedArray = new int[array.Length];

        for (int i = 0; i < sortedArray.Length; i++)
        {
            sortedArray[i] = FindMaxElementInPartitionOfArray(array, i, array.Length-1, i);
        }

        return sortedArray;
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}