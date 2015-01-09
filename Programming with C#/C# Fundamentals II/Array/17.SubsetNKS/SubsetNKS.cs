using System;
using System.Collections.Generic;

//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. Find in the array a subset of K elements that have sum S or indicate about its absence.

class SubsetNKS
{
    static void Main()
    {
        //input
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter array element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter S: ");
        int S = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());

        int chekedNumber = 0;
        List<int> subsetNumbers = new List<int>();
        bool hasSubsetSum = false;
        int maxi = (int)Math.Pow(2, array.Length) - 1;

        //check input array
        Console.WriteLine("Input array is: [{0}]", string.Join(",", array));
        Console.WriteLine("maxi : {0}", maxi);

        //logic
        for (int i = 0; i <= maxi; i++)
        {
            long currentSum = 0;
            for (int j = 1; j <= array.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += array[j - 1];
                    chekedNumber++;
                    subsetNumbers.Add(array[j - 1]);
                }
            }
            if (chekedNumber == K & currentSum == S)
            {
                hasSubsetSum = true;
                break;
            }
            else
            {
                chekedNumber = 0;
                subsetNumbers.Clear();
            }
        }

        if (hasSubsetSum)
        {
            Console.Write("Subset number is: ");
            for (int i = 0; i < subsetNumbers.Count; i++)
            {
                Console.Write(subsetNumbers[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No such subset.");
        }
    }
}