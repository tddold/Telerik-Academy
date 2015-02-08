/*Problem 10. Find sum in array
Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:
| array	                    | S	        | result
| 4, 3, 1, 4, 2, 5, 8	    | 11	    | 4, 2, 5
*/

using System;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

class FindSumInArray
{
    // EASE OF USE: The program contains test method that show us how the program work on diffent inputs
    // The method that tests the program is called "TestRunner"
    static void Main()
    {
        Console.Title = "Problem 10. Find sum in array";

        // setting culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("\nEnter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());
        PrintSeparateLine();

        // given sum
        Console.Write("\nEnter given sum: ");
        int sum = int.Parse(Console.ReadLine());

        // input array elements
        int[] array = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array", n);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Print input array
        PrintInputArray(array);

        // Find sequence in given sum
        List<int> resultArray = new List<int>();
        resultArray = FindSequenceInGivenSum(resultArray, array, sum);

        // Print result
        PrintResult(resultArray, sum);

        PrintSeparateLine();

        // TEST METHOD
        // TestRunner(resultArray);
    }

    private static void PrintResult(List<int> resultArray, int sum)
    {
        Console.WriteLine("On given sum {0}, sequence of number is: {1}", sum, string.Join(" ", resultArray));
    }

    private static List<int> FindSequenceInGivenSum(List<int> resultArray, int[] array, int sum)
    {
        resultArray.Clear();

        for (int i = 0; i < array.Length; i++)
        {
            int currSum = 0;

            if (sum == 0 )
            {
                if (array[i] == sum)
                {
                    resultArray.Clear(); 
                }
                else
                {
                    continue;
                }
                
                resultArray.Add(array[i]);
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] == sum)
                    {
                        resultArray.Add(array[j]);
                        i++;
                    }
                }
            }
            else
            {
                resultArray.Clear();

                for (int j = i; j < array.Length; j++)
                {
                    currSum += array[j];

                    if (currSum <= sum)
                    {
                        resultArray.Add(array[j]);
                    }
                    else
                    {
                        break;
                    }

                    if (currSum == sum)
                    {
                        return resultArray;
                    }
                }
            }
        }

        return resultArray;
    }

    private static void PrintInputArray(int[] array)
    {
        Console.Write("\nElements on input array are : ");
        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine();
    }

    private static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    private static void TestRunner(List<int> resultArray)
    {
        Console.Write(new string('*', 24));
        Console.Write("TestRunner");
        Console.WriteLine(new string('*', 24));

        int[] test0 = { 4, 3, 1, 4, 2, 5, 8 };
        int sum = 11;
        PrintInputArray(test0);
        FindSequenceInGivenSum(resultArray, test0, sum);
        PrintResult(resultArray, sum);
        PrintSeparateLine();

        int[] test1 = { 1, 2, 3, 4, 5, 8 };
        sum = 6;
        PrintInputArray(test1);
        FindSequenceInGivenSum(resultArray, test1, sum);
        PrintResult(resultArray, sum);
        PrintSeparateLine();

        int[] test2 = { 4, 3, 1, 4, 2, 5, 8 };
        sum = 0;
        PrintInputArray(test2);
        FindSequenceInGivenSum(resultArray, test2, sum);
        PrintResult(resultArray, sum);
        PrintSeparateLine();

        int[] test3 = { 4, 3, 0, 0, 0, 5, 8 };
        sum = 0;
        PrintInputArray(test3);
        FindSequenceInGivenSum(resultArray, test3, sum);
        PrintResult(resultArray, sum);
        PrintSeparateLine();
    }
}