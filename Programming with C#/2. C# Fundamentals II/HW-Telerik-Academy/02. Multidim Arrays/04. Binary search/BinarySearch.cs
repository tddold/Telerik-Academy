/*Problem 4. Binary search
Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K : ");
        int k = int.Parse(Console.ReadLine());
        PrintSeparateLine();

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write(" arr[{0}] : ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        FindLargestNumber(array, k);
    }

    static void FindLargestNumber(int[] array, int k)
    {
        Array.Sort(array);

        Console.Write("The sorted array is : ");
        Console.WriteLine(string.Join(", ", array));
        PrintSeparateLine();

        int index = Array.BinarySearch(array, k);

        if (index == -1)
        {
            Console.WriteLine("No such number");

        }
        else if (index < 0)
        {
            Console.WriteLine("The largest number smaller than {0} in the array is : {1}", k, array[(index * -1) - 2]);

        }
        else if (index > 0)
        {
            Console.WriteLine("The largest number smaller than {0} in the array is : {1}", k, array[index - 1]);
        }


    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}