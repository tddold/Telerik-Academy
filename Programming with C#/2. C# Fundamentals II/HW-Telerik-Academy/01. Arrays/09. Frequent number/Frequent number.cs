/*Problem 9. Frequent number
Write a program that finds the most frequent number in an array.
Example:
| input	                                | result
|4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3  | 4 (5 times)
 */

using System;
using System.Globalization;
using System.Threading;

class Program
{
    // EASE OF USE: The program contains test method that show us how the program work on diffent inputs
    // The method that tests the program is called "TestRunner"    
    static void Main()
    {
        Console.Title = "Problem 9. Frequent number";

        // setting culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 9. Frequent number!");
        PrintSeparateLine();

        Console.Write("\nEnter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());
        PrintSeparateLine();

        // input array elements
        int[] array = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array", n);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Print input array
        Console.Write("\nElements on input array are : ");
        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine();

        FindMostFrequentNumber(array);
        PrintSeparateLine();

        // TEST METHOD
        // TestRunners();

    }

    static void FindMostFrequentNumber(int[] array)
    {
        int maxNumbers = 0;
        int number = 0, count = 1;
        bool[] isCheckt = new bool[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            if (!isCheckt[i])
            {
                isCheckt[i] = true;
                count = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        isCheckt[j] = true;

                        if (maxNumbers < count)
                        {
                            maxNumbers = count;
                            number = array[i];
                        }
                    }
                }
            }
        }

        PrintResult(maxNumbers, number);
    }

    private static void PrintResult(int maxNumbers, int number)
    {
        if (maxNumbers == 0)
        {
            Console.WriteLine("Most repetitive number is   : No number ({1} times)", number, maxNumbers);
        }
        else
        {
            Console.WriteLine("Most repetitive number is   : {0} ({1} times)", number, maxNumbers);
        }
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    private static void TestRunners()
    {
        Console.Write(new string('*', 24));
        Console.Write("TestRunner");
        Console.WriteLine(new string('*', 24));

        int[] test0 = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        Console.Write("\nElements on test array are : ");
        Console.WriteLine(string.Join(" ", test0));
        Console.WriteLine();
        FindMostFrequentNumber(test0);
        PrintSeparateLine();

        int[] test1 = { 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 1, 1, 1 };
        Console.Write("\nElements on test array are : ");
        Console.WriteLine(string.Join(" ", test1));
        Console.WriteLine();
        FindMostFrequentNumber(test1);
        PrintSeparateLine();

        int[] test2 = { 4, 1, 1, 4, 2 };
        Console.Write("\nElements on test array are : ");
        Console.WriteLine(string.Join(" ", test2));
        Console.WriteLine();
        FindMostFrequentNumber(test2);
        PrintSeparateLine();

        int[] test3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.Write("\nElements on test array are : ");
        Console.WriteLine(string.Join(" ", test3));
        Console.WriteLine();
        FindMostFrequentNumber(test3);
        PrintSeparateLine();
    }
}