/*Problem 2. Compare arrays
Write a program that reads two integer arrays from the console and compares them element by element.*/

using System;
using System.Globalization;
using System.Threading;

class CompareArrays
{
    static void Main()
    {
        Console.Title = "Problem 2. Compare arrays";

        // setting for culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        // ****************hard coding for test*********************************
        // int[] firstArray = new int[]{1, 2, 3, 4, 5};  // isSimetric -true
        //                            {1, 2, 3, 4, 5};  // isSimetric - false
        //                            {1};              // diferant lenght

        // int[] secondArray = new int[]{1, 2, 3, 4, 5};
        //                             {1, 2, 3, 5, 4};
        //                             {1, 2, 3};
        // *********************************************************************

        // input
        Console.WriteLine("Compare arrays!");
        Console.WriteLine(new string('-', 40));

        Console.Write("Lenght first array : ");
        int lenghtFirstarray = int.Parse(Console.ReadLine());

        Console.Write("Lenght second array: ");
        int lenghtSecondArray = int.Parse(Console.ReadLine());

        int[] firstArray = new int[lenghtFirstarray];
        int[] secondArray = new int[lenghtSecondArray];

        bool isSimetric = true;
        int compareLenght;

        // add elements to first array
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Input elemsents first array:");

        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("Element ({0}) -- > ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        // add elements to second array
        Console.WriteLine("Input elemsents second array:");

        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("Element ({0}) -- > ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        // ****************print first and second array*****************
        // print first array using foreach
        Console.Write("First array : ");
        foreach (int item in firstArray)
        {
            Console.Write("{0}, ", item);
        }

        Console.WriteLine();

        //print second array using string.join
        Console.WriteLine("Second array: " + string.Join(", ", secondArray));

        // logic        
        if (firstArray.Length < secondArray.Length)
        {
            compareLenght = firstArray.Length;
        }
        else
        {
            compareLenght = secondArray.Length;
        }

        for (int i = 0; i > compareLenght; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                isSimetric = false;
                break;
            }
        }

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The arrays is simetric : {0}", isSimetric);
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }
}