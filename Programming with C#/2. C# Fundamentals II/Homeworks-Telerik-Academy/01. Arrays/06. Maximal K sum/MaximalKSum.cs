﻿/*Problem 6. Maximal K sum
Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class MaxIncreasingSequence
{
    // EASE OF USE: The program contains test method that show us how the program work on diffent inputs
    // The method that tests the program is called "TestRunner"

    static void Main()
    {
        
        // TestRunner(); // <- TEST METHOD
    }

    

    static void TestRunner()
    {
        Console.WriteLine(new string('-', 40));

        int[] test0 = { 8, 1, 3, 5, 7, 9, 8 };
        PrintMaxIncreasingSequence(test0, FindMaxIncreasingSequence(test0));

        int[] test1 = { 1 };
        PrintMaxIncreasingSequence(test1, FindMaxIncreasingSequence(test1));

        int[] test2 = { 1, 2, 3, 4, 1 };
        PrintMaxIncreasingSequence(test2, FindMaxIncreasingSequence(test2));

        int[] test3 = { 6, 1, 2, 3, 5 };
        PrintMaxIncreasingSequence(test3, FindMaxIncreasingSequence(test3));

        int[] test4 = { 6, 5, 4, 3, 2, 1 };
        PrintMaxIncreasingSequence(test4, FindMaxIncreasingSequence(test4));

        int[] test5 = { 1, 2, 3, 4, 9 };
        PrintMaxIncreasingSequence(test5, FindMaxIncreasingSequence(test5));

        int[] test6 = { 1, 2, 3, 7, 1, 2, 3, 4, 8 };
        PrintMaxIncreasingSequence(test6, FindMaxIncreasingSequence(test6));

        int[] test7 = { 2, 4, 6, 1, 2, 3, 4, 1, 3, 5, 7, 9 };
        PrintMaxIncreasingSequence(test7, FindMaxIncreasingSequence(test7));

        int[] test8 = { 1, 1, 2, 2, 2, 3, 4, 5 };
        PrintMaxIncreasingSequence(test8, FindMaxIncreasingSequence(test8));

        int[] test9 = { 8, 1, 3, 5, 7, 9, 8 };
        PrintMaxIncreasingSequence(test9, FindMaxIncreasingSequence(test9));

        Console.WriteLine("\n" + new string('-', 40));
    }
}