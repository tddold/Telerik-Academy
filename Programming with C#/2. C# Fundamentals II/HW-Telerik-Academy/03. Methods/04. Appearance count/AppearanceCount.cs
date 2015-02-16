/*Problem 4. Appearance count
Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.*/

using System;

public class AppearanceCount
{
    static void Main()
    {
        Console.Title = "Problem 4. Appearance count";

        Console.WriteLine("Problem 4. Appearance count!");
        PrintSeparateLine();

        Console.Write("Enter lenght of array: ");
        int lenght = int.Parse(Console.ReadLine());

        Console.Write("Enter wanted number: ");
        int number = int.Parse(Console.ReadLine());

        PrintSeparateLine();

        int[] array = new int[lenght];
        Console.WriteLine("Enter lements of array:\n");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" arr[{0}] -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        PrintSeparateLine();
        PrintArray(array);

        int counter = CountNumberInArray(array, number);
        Console.WriteLine("\nThe number : {0} , appears {1} times in the array.", number, counter);
        PrintSeparateLine();
    }

    public static int CountNumberInArray(int[] array, int number)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num == number)
            {
                count++;
            }
        }

        return count;
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine("Input array is: {0}", string.Join(",", array));
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}