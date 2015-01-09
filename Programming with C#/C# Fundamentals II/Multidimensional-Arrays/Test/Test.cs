using System;
using System.Collections;

class SortStringArrayByLength
{
    class StringComparer : IComparer
    {
        public int Compare(object a, object b)
        {
            if (a.ToString().Length != b.ToString().Length)
            {
                return a.ToString().Length.CompareTo(b.ToString().Length);
            }
            else
            {
                return a.ToString().CompareTo(b.ToString());
            }
        }
    }

    static void Main()
    {

        Console.Write("Input number of elements n: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        Console.WriteLine("Input string elements!");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = Console.ReadLine();
        }

        Array.Sort(array, new StringComparer());

        foreach (string element in array)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }
}