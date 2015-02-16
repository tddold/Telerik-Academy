/*Problem 2. Get largest number
Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().*/

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.Title = "Problem 2. Get largest number";

        Console.WriteLine("Problem 2. Get largest number!");
        PrintSeparateLine();

        Console.Write("Enter first number : ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number : ");
        int n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBiggest number is: {0}\n", GetMax((GetMax(n1, n2)), n3));

        PrintSeparateLine();

    }

    static int GetMax(int n1, int n2)
    {
        return Math.Max(n1, n2);
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}