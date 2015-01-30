/*Problem 1. Allocate array
Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.*/

using System;
using System.Globalization;
using System.Threading;

class AllocateArray
{
    static void Main()
    {
        Console.Title = "Problem 1. Allocate array";

        // setting for culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;               

        const int arrayLenght = 20;
        const int multiplier = 5;

        int[] array = new int[arrayLenght];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * multiplier;
        }

        Console.WriteLine("Print the obtained array on the console.");
        Console.WriteLine(new string('-', 40));

        // Print Array using foreach
        Console.WriteLine("Print using foreach: ");
        foreach (int number in array)
        {
            Console.Write("{0} ", number);
        }

        Console.WriteLine();
        Console.WriteLine();

        // Print Array using string.Join()
        Console.WriteLine("Print using string.Join: ");
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine(new string('-', 80));
    }
}