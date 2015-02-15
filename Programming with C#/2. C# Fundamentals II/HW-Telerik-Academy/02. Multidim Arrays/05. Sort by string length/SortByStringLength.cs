/*Problem 5. Sort by string length
You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array : ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        Console.WriteLine("Enter the string elements of the array : \n");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" arr[{0}] : ", i);
            array[i] = Console.ReadLine();
        }

        PrintSeparateLine();
        Console.WriteLine("\nBefore sorting: {0}", string.Join(", ", array));
        PrintSeparateLine();

        array = SelectionSortByLength(array);

        Console.WriteLine("After sorting: {0}\n", string.Join(", ", array));
        PrintSeparateLine();
    }

    static string[] SelectionSortByLength(string[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int index = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].Length < array[index].Length)
                {
                    index = j;
                }
            }

            string swap = array[i];
            array[i] = array[index];
            array[index] = swap;
        }
        return array;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}