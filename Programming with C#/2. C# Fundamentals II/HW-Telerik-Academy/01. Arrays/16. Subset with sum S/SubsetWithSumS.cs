/*Problem 16.* Subset with sum S
We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.
Example:
| input array	            | S	    | result
| 2, 1, 2, 4, 3, 5, 2, 6	| 14	| yes
*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class SubsetWithSumS
{
    static void Main()
    {
        Console.Title = "Problem 16.* Subset with sum S";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 16.* Subset with sum S!");
        PrintSeparateLine();

        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of sum: ");
        int s = int.Parse(Console.ReadLine());

        PrintSeparateLine();

        int[] array = new int[n];
        Console.WriteLine("Enter the elements of array:\n");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" arr[{0}] --> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        PrintSeparateLine();

        // finnd subset with sum s
        bool isSum = false;
        isSum = SubsetWithSum(array, s, isSum);

        PrintArray(isSum);
        PrintSeparateLine();

        // TEST METHOD
        // TestRunner(s, isSum);
    }

    static bool SubsetWithSum(int[] array, int s, bool isSum)
    {
        int n = array.Length;
        int subsetCombination = (int) Math.Pow(2, n);

        for (int i = 0; i < subsetCombination; i++)
        {
            string str = Convert.ToString(i, 2).PadLeft(n, '0');
            int cubsetSum = 0;

            for (int j = 0; j < n; j++)
            {
                if (str[j] == '1')
                {
                    cubsetSum += array[j];

                    if (cubsetSum == s)
                    {
                        isSum = true;
                        return isSum;
                    }
                    else if (cubsetSum > s)
                    {
                        break;
                    }
                }
            }
        }

        return isSum;
    }

    static void PrintArray(bool isSum)
    {
        if (isSum)
        {
            Console.WriteLine("Result is --> yes");
        }
        else
        {
            Console.WriteLine("Result is --> no");
        }
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void TestRunner(int s, bool isSum)
    {
        Console.Write(new string('*', 24));
        Console.Write("TestRunner");
        Console.WriteLine(new string('*', 24));

        int[] test0 = { 2, 1, 2, 4, 3, 5, 2, 6 };
        isSum = false;
        isSum = SubsetWithSum(test0, s, isSum);
        Console.WriteLine("Test array: {0}", string.Join(" ", test0));
        PrintArray(isSum);
        PrintSeparateLine();

        int[] test1 = { 1, 1, 1, 1, 1, 1 };
        isSum = false;
        isSum = SubsetWithSum(test1, s, isSum);
        Console.WriteLine("Test array: {0}", string.Join(" ", test1));
        PrintArray(isSum);
        PrintSeparateLine();
    }
}