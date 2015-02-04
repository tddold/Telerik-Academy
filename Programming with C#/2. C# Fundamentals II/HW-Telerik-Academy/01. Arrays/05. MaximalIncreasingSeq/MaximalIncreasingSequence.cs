/*Problem 5. Maximal increasing sequence
Write a program that finds the maximal increasing sequence in an array.
Example:
| input	                | result    |
| 3, 2, 3, 4, 2, 2, 4	| 2, 3, 4   |
 */

using System;
using System.Globalization;
using System.Threading;

class MaximalIncreasingSequence
{
    // EASE OF USE: The program contains test method that show us how the program work on diffent inputs
    // The method that tests the program is called "TestRunner"

    static void Main()
    {
        Console.Title = "Problem 5. Maximal increasing sequence";

        // setting  for culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 5. Maximal increasing sequence!");
        Console.WriteLine(new string('-', 40));

        Console.Write("Enter lenght of array: ");
        int lenghtArray = int.Parse(Console.ReadLine());

        int[] array = new int[lenghtArray];

        // input elements of array
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Enter each element of a different row!");
        Console.WriteLine();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("  {0, 2} element: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        // logic
        int maxSequence;
        int startSequence;
        int endSequence;
        FindMaxIncreasingSequence(lenghtArray, array, out maxSequence, out startSequence, out endSequence);

        // print result
        Console.WriteLine(new string('-', 40));

        PrintMaxIncreasingSequence(array, maxSequence, startSequence, endSequence);

        Console.WriteLine(new string('-', 40));

        // TEST METHOD
        // TestRunner(lenghtArray, array, out maxSequence, out startSequence, out endSequence);
    }

    private static void FindMaxIncreasingSequence(int lenghtArray, int[] array, out int maxSequence, out int startSequence, out int endSequence)
    {
        maxSequence = 1;
        int count = 1;
        bool isStart = true;
        bool restat = true;
        startSequence = 0;
        endSequence = 0;
        int tmpStartSeq = 0;
        int tmpEndSeq = 0;

        for (int i = 0; i < lenghtArray - 1; i++)
        {
            bool isNotEqual = false;

            if (array[i] + 1 != array[i + 1])
            {
                isNotEqual = true;
            }
            else
            {
                if (restat)
                {
                    tmpStartSeq = 0;
                    tmpStartSeq = 0;
                    restat = false;
                }

                if (isStart)
                {
                    tmpStartSeq = i;
                    isStart = false;
                }
                count++;
                tmpEndSeq = i + 1;
            }

            if (maxSequence < count && isNotEqual)
            {
                maxSequence = count;
                startSequence = tmpStartSeq;
                endSequence = tmpEndSeq;
                restat = true;
                isStart = true;
                count = 1;
            }
        }

        if (maxSequence < count)
        {
            maxSequence = count;
            startSequence = tmpStartSeq;
            endSequence = tmpEndSeq;
        }
    }

    private static void PrintMaxIncreasingSequence(int[] array, int maxSequence, int startSequence, int endSequence)
    {
        // print input array
        Console.Write("Input array is : ");
        Console.WriteLine(string.Join(", ", array));

        // print output sequence
        if (maxSequence == 1)
        {
            Console.WriteLine("There is not sequence of increasing elements!");
        }
        else
        {
            Console.Write("Max sequence is: ");

            for (int i = startSequence; i <= endSequence; i++)
            {
                Console.Write("{0}, ", array[i]);
            }

            Console.WriteLine();
        }
    }

    static void TestRunner(int lenghtArray, int[] array, out int maxSequence, out int startSequence, out int endSequence)
    {
        Console.Write("\n" + new string('*', 24));
        Console.Write("Test Runner!");
        Console.WriteLine(new string('*', 24));

        Console.WriteLine("Tesst 0");
        Console.WriteLine();
        int[] test0 = { 3, 2, 3, 4, 2, 2, 4 };
        lenghtArray = 7;
        FindMaxIncreasingSequence(lenghtArray, test0, out maxSequence, out startSequence, out endSequence);
        PrintMaxIncreasingSequence(test0, maxSequence, startSequence, endSequence);
        Console.WriteLine(new string('-', 60));

        Console.WriteLine("Tesst 1");
        Console.WriteLine();
        int[] test1 = { 1 };
        lenghtArray = 1;
        FindMaxIncreasingSequence(lenghtArray, test1, out maxSequence, out startSequence, out endSequence);
        PrintMaxIncreasingSequence(test1, maxSequence, startSequence, endSequence);
        Console.WriteLine(new string('-', 60));

        Console.WriteLine("Tesst 2");
        Console.WriteLine();
        lenghtArray = 3;
        int[] test2 = { 1, 2, 3 };
        FindMaxIncreasingSequence(lenghtArray, test2, out maxSequence, out startSequence, out endSequence);
        PrintMaxIncreasingSequence(test2, maxSequence, startSequence, endSequence);
        Console.WriteLine(new string('-', 60));

        Console.WriteLine("Tesst 3");
        Console.WriteLine();
        lenghtArray = 11;
        int[] test3 = { 8, 1, 2, 3, 4, 5, 7, 8, 9, 8, 0 };
        FindMaxIncreasingSequence(lenghtArray, test3, out maxSequence, out startSequence, out endSequence);
        PrintMaxIncreasingSequence(test3, maxSequence, startSequence, endSequence);
        Console.WriteLine(new string('-', 60));

        Console.WriteLine("Tesst 4");
        Console.WriteLine();
        lenghtArray = 15;
        int[] test4 = { 8, 1, 3, 5, 7, 9, 8, 0, 2, 3, 4, 5, 6, 7, 8 };
        FindMaxIncreasingSequence(lenghtArray, test4, out maxSequence, out startSequence, out endSequence);
        PrintMaxIncreasingSequence(test4, maxSequence, startSequence, endSequence);
        Console.WriteLine(new string('-', 60));

        Console.WriteLine("Tesst 5");
        Console.WriteLine();
        lenghtArray = 7;
        int[] test5 = { 8, 1, 3, 5, 7, 9, 8 };
        FindMaxIncreasingSequence(lenghtArray, test5, out maxSequence, out startSequence, out endSequence);
        PrintMaxIncreasingSequence(test5, maxSequence, startSequence, endSequence);
        Console.WriteLine(new string('-', 60));
    }
}