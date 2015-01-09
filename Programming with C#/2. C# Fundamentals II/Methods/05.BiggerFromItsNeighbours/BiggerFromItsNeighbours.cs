using System;

/*Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
*/

public class BiggerFromItsNeighbours
{
    public static bool BiggerThanItsNeghbours(int[] array, int position)
    {
        if (position < 0 || position >= array.Length)
        {
            throw new IndexOutOfRangeException();
        }
        else if (position == array.Length - 1 && array.Length > 1)
        {
            return array[position - 1] < array[position];
        }
        else if (position == 0 && array.Length > 1)
        {
            return array[position] > array[position + 1];
        }
        else
        {
            return (array[position] > array[position - 1] && array[position] > array[position + 1]);
        }
    }

    static void Main()
    {
        Console.Write("Enter positon number: ");
        int position = int.Parse(Console.ReadLine());
        int[] array = { 1, 4, 9, 3, 7, 8, 2, 6 };

        if (BiggerThanItsNeghbours(array, position))
        {
            Console.WriteLine("The number is bigger!");
        }
        else
        {
            Console.WriteLine("The number is smoller!");
        }

        Console.WriteLine();
    }
}