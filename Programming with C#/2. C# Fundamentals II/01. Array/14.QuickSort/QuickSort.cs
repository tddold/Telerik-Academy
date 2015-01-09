using System;
using System.Linq;

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).


class QuickSort
{
    static void Main()
    {
        int[] array = { 5, 3, 7, 2, 9, 1, 8, 4, 6 };

        //check array
        Console.WriteLine("\nBefore sorting: {0}", string.Join(" ", array));

        QuickSorts(array, 0, array.Length-1);

        Console.WriteLine("After sorting: {0}\n", string.Join(" ", array));
    }

    public static void QuickSorts(int[] elements, int left, int right)
    {
        if (left >= right)
        {
            return; // dano na racurciqta
        }
        int i = left;
        int j = right;
        int pivotElement = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivotElement) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivotElement) > 0)
            {
                j++;
            }

            if (i <= j)
            {
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;
                i++;
                j++;
            }
        }

        // Recursive calls
        if (left < j)
        {
            QuickSorts(elements, left, j);
        }

        if (i < right)
        {
            QuickSorts(elements, i, right);
        }
    }
}