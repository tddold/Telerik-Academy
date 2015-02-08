/*Problem 19.* Permutations of set
Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
Example:

N	| result
3	| {1, 2, 3} 
    | {1, 3, 2} 
    | {2, 1, 3} 
    | {2, 3, 1} 
    | {3, 1, 2} 
    | {3, 2, 1}
*/

using System;
using System.Globalization;
using System.Threading;

class PermutationsOfSet
{
    static void Main()
    {
        Console.Title = "Problem 19.* Permutations of set";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 19.* Permutations of set!");
        PrintSeparateLine();

        Console.Write("Enter the size of the array: n = ");
        int n = int.Parse(Console.ReadLine());

        PrintSeparateLine();

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        Console.WriteLine("All permutations is:\n");
        Permutations(array, 0);
        PrintSeparateLine();
    }

    static void Permutations(int[] array, int k)
    {
        if (k == array.Length-1)
        {
            Console.WriteLine("(" + String.Join(", ", array) + ")");
            return;
        }

        Permutations(array, k + 1);

        for (int i = k+1; i < array.Length; i++)
        {
            Swap(array, k, i);

            Permutations(array, k + 1);

            // backtrack
            Swap(array, k, i);
        }
    }

    private static void Swap(int[] array, int k, int i)
    {
        int tmp = array[k];
        array[k] = array[i];
        array[i] = tmp;
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}