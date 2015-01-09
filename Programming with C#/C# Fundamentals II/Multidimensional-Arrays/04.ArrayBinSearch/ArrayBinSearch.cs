using System;
using System.Collections.Generic;

/*Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

Exzamle:

Source array that is ordered ascendin.

string[] arrayTwo = { "a", "e", "m", "n", "x", "z" };

Call versions of the BinarySearch method.
int indez1 = Array.BinarySearch(arrayTwo, "m");
int index2 = Array.BinarySearch<string>(arrayTwo, "x");
int index3 = Array.BinarySearch<string>(arrayTwo, "E", StringComparer.OrdinalIgnoreCase);

Write result.

Console.WriteLine(indez1);
Console.WriteLine(index2);
Console.WriteLine(index3);
*/

class ArrayBinSearch
{
    static List<int> QuickSort(List<int> array)
    {
        if (array.Count <= 1)
        {
            return array;
        }

        int pivot = array[array.Count / 2];
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        for (int i = 0; i < array.Count; i++)
        {
            if (i != array.Count / 2)
            {
                if (array[i] <= pivot)
                {
                    left.Add(array[i]);
                }
                else
                {
                    right.Add(array[i]);
                }
            }
        }

        return ConcatenateArrays(QuickSort(left), pivot, QuickSort(right));
    }

    static List<int> ConcatenateArrays(List<int> left, int pivot, List<int> right)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < left.Count; i++)
        {
            result.Add(left[i]);
        }

        result.Add(pivot);

        for (int i = 0; i < right.Count; i++)
        {
            result.Add(right[i]);
        }

        return result;
    }

    static void PrintArray(int[] array)
    {
        Console.Write(string.Join(",", array));
        Console.WriteLine();
    }

    static void Main()
    {
        ////input
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number for BinerySearch: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        /*Random rdn = new Random();*/
        /*for (int i = 0; i < N; i++)
        {
            array[i] = rdn.Next(1, 100);
        }
        */

        Console.WriteLine("Enter elements a array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0, 5}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        /*Print input array*/
        PrintArray(array);

        /*logic*/
        List<int> arrayOfIntegers = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            arrayOfIntegers.Add(array[i]);
        }

        Console.Write(string.Join(",", arrayOfIntegers));
        Console.WriteLine();
        Console.WriteLine();

        /*Retyrn result of QuickSort metod and print sort array*/
        List<int> sortedArray = QuickSort(arrayOfIntegers);
        Console.Write(string.Join(",", sortedArray));
        Console.WriteLine();

        /*Write sorted List to array and use Array>BynerySearch*/
        for (int i = 0; i < sortedArray.Count; i++)
        {
            array[i] = sortedArray[i];
        }

        int index = Array.BinarySearch(array, k);
        if (index >= 0)
        {
            Console.WriteLine("Index for number {0} is: {1}", k, index);    
        }
        else
        {
            Console.WriteLine("There is no number that equal on k!");
        }
    }
}