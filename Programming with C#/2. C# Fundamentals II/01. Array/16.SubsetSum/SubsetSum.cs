using System;
using System.Collections.Generic;

//16.* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
//  arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)
class SubsetSum
{
    static void Main()
    {
        //input
        int[] arrayOfNumbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int maxi = (int)Math.Pow(2, arrayOfNumbers.Length) - 1;
        Console.Write("Enter sum: ");
        int S = int.Parse(Console.ReadLine());
        List<int> tmpElements = new List<int>();
        int hasSum = 0;

        //logic
        for (int i = 1; i <= maxi; i++)
        {
            int currentSum = 0;
            tmpElements.Clear();
            for (int j = 1; j <= arrayOfNumbers.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += arrayOfNumbers[j - 1];
                    tmpElements.Add(arrayOfNumbers[j - 1]);
                }

                if (currentSum == S)
                {
                    hasSum++;
                    Console.Write("Elements is :");

                    foreach (var item in tmpElements)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
            }
        }


        if (hasSum == 0)
        {
            Console.WriteLine("No of sum.");
        }
        else
        {
            Console.WriteLine("Number of sum is :{0}", hasSum);
        }
    }
}