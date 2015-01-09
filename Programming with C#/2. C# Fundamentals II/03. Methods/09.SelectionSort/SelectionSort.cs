using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.
*/

public class SelectionSort
{
    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + (i == arr.Length - 1 ? "\n" : " "));
        }
    }

    public static void Swap(int[] arr, int i, int j)
    {
        int tmp = arr[j];
        arr[j] = arr[i];
        arr[i] = tmp;
    }

    public static int GetMaximalElement(int[] arr, int i, bool descending)
    {
        int maxElement = i;

        for (i++; i < arr.Length; i++)
        {
            if (descending)
            {
                /*for ascending*/
                if (arr[maxElement] > arr[i])
                {
                    maxElement = i;
                }
            }
            else
            {
                /*for descending*/
                if (arr[i] > arr[maxElement])
                {
                    maxElement = i;
                }
            }
        }

        return maxElement;
    }

    public static void SortArray(int[] arr, bool descending = false)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Swap(arr, i, GetMaximalElement(arr, i, descending));
        }
    }

    static void Main()
    {
        int[] arr = { -1, -3, 4, -5, 6, -7 };

        /* Ascending*/
        SortArray(arr);
        PrintArray(arr);

        /*Descending*/
        SortArray(arr, descending: true);
        PrintArray(arr);
    }
}