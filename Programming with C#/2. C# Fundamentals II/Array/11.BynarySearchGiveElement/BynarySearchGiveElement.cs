using System;

//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).


class BynarySearchGiveElement
{
    static void Main()
    {
        //input
        Console.Write("Enter lenght of array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element [{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //int[] array = { 5, 4, 8, 3, 1, 2, 6, 7, 9 };
        Console.Write("Enter key:");
        int findeElement = int.Parse(Console.ReadLine());
        //int findeElement = 7;
        int startElement = 0;
        int endElement = array.Length - 1;
        int midElement = (startElement + endElement) / 2; ;
        int indexFindElement = 0;

        //check array
        Console.Write(string.Join(",", array));
        Console.WriteLine();

        //sorte array
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }

        //check sor array
        Console.Write(string.Join(",", array));
        Console.WriteLine();

        //logic
        while (startElement <= endElement)
        {
            midElement = (startElement + endElement) / 2;

            if (findeElement == array[midElement])
            {
                indexFindElement = midElement;
                break;
            }
            else if (findeElement < array[midElement])
            {
                endElement = midElement - 1;
            }
            else if (findeElement > array[midElement])
            {
                startElement = midElement + 1;
            }
        }
        

        //output
        Console.Write("Index of finde element is: {0}", indexFindElement);
        Console.WriteLine();
    }
}