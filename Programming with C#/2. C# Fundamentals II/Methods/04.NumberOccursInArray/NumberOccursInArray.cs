using System;
/*Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.
*/

public class NumberOccursInArray
{
    public static int CountNumber(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main()
    {
        Console.Write("Enter test number: ");
        int testNumber = int.Parse(Console.ReadLine());

        int[] array = new int[] { 1, 2, 2, 3, 5, 5, 5, 6, 6, 6, 6 };

        Console.WriteLine("\nNumber {0} occurs {1} time(s) in the array!\n", testNumber, CountNumber(array, testNumber));
    }
}