/*Problem 5. Larger than neighbours
Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).*/

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Title = "Problem 5. Larger than neighbours";

        Console.WriteLine("Problem 5. Larger than neighbours!");
        PrintSeparateLine();

        Console.Write("Enter lenght of array: ");
        int lenght = int.Parse(Console.ReadLine());

        Console.Write("Enter wanted position in array: ");
        int position = int.Parse(Console.ReadLine());

        PrintSeparateLine();

        int[] array = new int[lenght];
        Console.WriteLine("Enter lements of array:\n");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" arr[{0}] -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        PrintSeparateLine();
        PrintArray(array);

        Console.WriteLine("\nNumber {0} (at index {1}) is bigger than its neighbours -> {2}\n", array[position], position, IsBiggerThanHeighbors(array, position));

        PrintSeparateLine();
    }

    static bool IsBiggerThanHeighbors(int[] array, int position)
    {
        bool isEqual = true;

        if (position < 0 || position > array.Length)
        {
            throw new IndexOutOfRangeException();
        }

        if (position > 0)
        {
            if (array[position] < array[position - 1])
            {
                isEqual = false;
            }
        }

        if (position < array.Length)
        {
            if (array[position] < array[position + 1])
            {
                isEqual = false;
            }
        }

        return isEqual;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("Input array is: {0}", string.Join(",", array));
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}