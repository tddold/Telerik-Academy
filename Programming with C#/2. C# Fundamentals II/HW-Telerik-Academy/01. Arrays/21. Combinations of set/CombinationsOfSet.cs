/*Problem 21.* Combinations of set
Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
Example:
N	K	result
5	2	{1, 2} 
        {1, 3} 
        {1, 4} 
        {1, 5} 
        {2, 3} 
        {2, 4} 
        {2, 5} 
        {3, 4} 
        {3, 5} 
        {4, 5}
 */

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class CombinationsOfSet
{
    static int k;
    static int n;
    static int[] array;
    static void Main()
    {
        Console.Title = "Problem 21.* Combinations of set";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 21.* Combinations of set!");
        PrintSeparateLine();

        Console.Write("Enter the size of the array: n = ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter the number the elements to calculate to Combinations: k = ");
        k = int.Parse(Console.ReadLine());

        PrintSeparateLine();

        array = new int[k];

        Console.WriteLine("All Combinations is:\n");
        Combinations(0, 1);
        PrintSeparateLine();
    }

    static void Combinations(int index, int start)
    {
        if (index >= k)
        {
            PrintLoops();
        }
        else
        {
            for (int i = start; i <= n; i++)
            {
                array[index] = i;

                Combinations(index + 1, i + 1);
            }
        }
    }

    static void PrintLoops()
    {
        Console.WriteLine("(" + String.Join(", ", array) + ")");
    }
    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}