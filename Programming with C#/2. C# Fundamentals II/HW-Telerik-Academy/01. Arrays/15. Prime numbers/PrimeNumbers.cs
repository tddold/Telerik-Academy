/*Problem 15. Prime numbers
Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class PrimeNumbers
{
    static void Main()
    {
        Console.Title = "Problem 15. Prime numbers";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 15. Prime numbers!");
        PrintSeparateLine();

        Console.Write("Enter the size of the array in range (1 - 10000000): ");
        int n = int.Parse(Console.ReadLine());

        bool[] array = new bool[n];
        PrintSeparateLine();

        // finds all prime numbers using Sieve of Eratosthenes Algorithm
        FindPrimeNumbers(array);

        Console.WriteLine("All prime numbers in range (1 - {0}) is:\n", n);
        PrintArray(array);
        PrintSeparateLine();
    }

    static void FindPrimeNumbers(bool[] array)
    {
        int n = array.Length;
        int searchLenght = (int)Math.Sqrt(n);
        for (int i = 2; i < searchLenght; i++)
        {
            // Skip these which is not prime
            if (!array[i])
            {
                for (int j = i * i; j < n; j += i)
                {
                    array[j] = true;
                }
            }
        }
    }

    static void PrintArray(bool[] array)
    {
        int counter = 0;
        for (int i = 2; i < array.Length; i++)
        {
            if (!array[i])
            {
                counter++;
                Console.WriteLine("{1,5} -> {0, 5} ", i, counter);
            }
        }

        Console.WriteLine("\nThe number of prime numbers is: {0}", counter);
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}