// 07.Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.



using System;

class SortArray
{
    static void Main()
    {
        //input
        Console.Write("Enter the array size(n): ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n]; //{ 64, 25, 12, 22, 11 };       

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //check input
        Console.WriteLine(string.Join(",", array));
        Console.WriteLine();

        //lpgic
        for (int i = 0; i < array.Length-1; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int tmp = array[j];
                    array[j] = array[i];
                    array[i] = tmp;
                }
            }
        }

        //output
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(string.Join(",", array));
    }
}