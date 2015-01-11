/*Problem 12.* Zero Subset
We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.*/

using System;
using System.Collections.Generic;
using System.Linq;

class ZeroSubset
{
    static void Main()
    {
        string input = Console.ReadLine();

        int[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x)).ToArray();

        //    int result;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        for (int j = i + 1; j < numbers.Length; j++)
        //        {
        //            for (int k = j+1; k < numbers.Length; k++)
        //            {
        //                for (int l = k + 1; l < numbers.Length; l++)
        //                {
        //                    result = numbers[i] + numbers[j] + numbers[k] + numbers[l] +
        //                        numbers[numbers.Length - 1];

        //                    if (result == 0)
        //                    {
        //                        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", numbers[i], numbers[j], numbers[k], numbers[l], numbers[numbers.Length-1], result);
        //                    }
        //                }
        //            }
        //        }
        //    }
    }

}