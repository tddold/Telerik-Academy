/*Problem 4. Maximal sequence
Write a program that finds the maximal sequence of equal elements in an array.
Example:
| input	                        | result    |
| 2, 1, 1, 2, 3, 3, 2, 2, 2, 1	| 2, 2, 2   |
 */

using System;
using System.Globalization;
using System.Threading;

class MaximalSequence
{
    static void Main()
    {
        Console.Title = "Problem 4. Maximal sequence";

        // setting for culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 4. Maximal sequence!");
        Console.WriteLine(new string('-', 40));

        Console.Write("Enter lenght of array: ");
        int lenghtArray = int.Parse(Console.ReadLine());

        int[] array = new int[lenghtArray]; 
        
        // ****************for test***********************************************************
        // int[] array = new int[]{2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
        // ***********************************************************************************

        // input elements of array
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Enter each element of a different row.");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter the N: {0, 2} element: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        // print array
        Console.WriteLine();
        Console.Write("Input array is: ");
        Console.WriteLine(string.Join(",", array));

        // logic
        int maxSequence = int.MinValue;
        int result = new int();

        for (int i = 0; i < lenghtArray; i++)
        {
            int count = 1;

            for (int j = i + 1; j < lenghtArray; j++)
            {
                if (array[i] != array[j])
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            if (maxSequence < count)
            {
                maxSequence = count;
                result = array[i];
            }
        }

        // print result
        Console.WriteLine(new string('-', 40));

        if (maxSequence == 1)
        {
            Console.WriteLine("There is not sequence of equal elements!");
        }
        else
        {
            Console.Write("Max sequence is: ");

            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write("{0}, ", result);
            }

            Console.WriteLine();
        }
        
        Console.WriteLine(new string('-', 40));     
    }
}