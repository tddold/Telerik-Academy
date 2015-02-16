/*Problem 6. First larger than neighbours
Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.*/

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Title = "Problem 6. First larger than neighbours";

        Console.WriteLine("Problem 6. First larger than neighbours!");
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
        PrintArray(array);

        int index = FindFirstBiggerThanNeighbors(array);

        if (index != -1)
        {
            Console.WriteLine("\nThe first element with equal neighbors is {0} , on position {1}", array[index], index);
        }
        else
        {
            Console.WriteLine("There is no such number");
        }

        PrintSeparateLine();

    }

    static int FindFirstBiggerThanNeighbors(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            bool firstEqual = IsBiggerThanHeighbors(array, i);

            if (firstEqual)
            {
                return i;
            }
        }

        return -1;

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

    public static void PrintArray(int[] array)
    {
        Console.WriteLine("Input array is: {0}", string.Join(",", array));
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}
