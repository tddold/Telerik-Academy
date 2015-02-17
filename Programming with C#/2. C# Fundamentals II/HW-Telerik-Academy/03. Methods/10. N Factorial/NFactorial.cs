﻿/*Problem 10. N Factorial
Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class NFactorial
{
    static void Main()
    {
        Console.Title = "Problem 10. N Factorial";

        Console.WriteLine("Problem 10. N Factorial!");
        PrintSeparateLine();

        Console.Write("Enter a non-negative number N: ");
        int n = int.Parse(Console.ReadLine());

        List<int> factorial = Factorial(n);
        Console.WriteLine("\n {0}! = {1}", n, string.Join("", factorial));
        PrintSeparateLine();
    }

    private static List<int> Factorial(int n)
    {
        int[] a = { 1 };

        for (int i = 2; i <= n; i++)
        {
            int[] b = i.ToString().Select(ch => ch - '0').ToArray();
            int[] c = new int[a.Length + b.Length];

            for (int j = a.Length - 1; j >= 0; j--)
            {
                for (int k = b.Length - 1; k >= 0; k--)
                {
                    c[(a.Length - 1) - j + (b.Length - 1) - k] += a[j] * b[k];
                }
            }

            int digits = 0, carry = 0;

            for (int j = 0; j < c.Length; j++)
            {
                digits = c[j] + carry;
                c[j] = digits % 10;
                carry = digits / 10;
            }

            a = c;

            Array.Reverse(a);
        }

        int index = 0;

        // remove zero before first digit (00120)
        while (a[index] == 0)
        {
            index++;
        }

        List<int> result = new List<int>();
        for (int i = index; i < a.Length; i++)
        {
            result.Add(a[i]);
        }

        return result;
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}