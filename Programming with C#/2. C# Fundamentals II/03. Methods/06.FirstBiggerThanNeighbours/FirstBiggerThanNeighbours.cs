using System;

/*Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.
*/

public class FirstBiggerThanNeighbours
{
    public static int FindFirstBiggerThanNeighours(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            if (BiggerThanItsNeghbours(array, index))
            {
                return index;
            }
        }

        return -1;
    }

    public static bool BiggerThanItsNeghbours(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException();
        }
        else if (index == array.Length - 1 && array.Length > 1)
        {
            return array[index - 1] < array[index];
        }
        else if (index == 0 && array.Length > 1)
        {
            return array[index] > array[index + 1];
        }
        else
        {
            return (array[index] > array[index - 1] && array[index] > array[index + 1]);
        }
    }

    static void Main()
    {
        Console.Write("Enter a saize on array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array", n);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("     {0}:    ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int index = FindFirstBiggerThanNeighours(array);

        if (index != -1)
        {
            Console.WriteLine("\nFirst number bigger its neighbours -> number: {0} at index: {1}\n", array[index], index);
        }

        Console.WriteLine();
    }
}