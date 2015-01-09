using System;
using System.Collections.Generic;

/*You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/


class SortArrayOfStrings
{
    static void Main(string[] args)
    {
        /*input*/
        string[] array = { "three", "one", "four", "tow", "five" };
        Console.WriteLine(string.Join(",", array));
        List<int> sortedArray = new List<int>();
        int[] tmpArray = new int[array.Length];
        string[] sortArray = new string[array.Length];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sortedArray.Add(array[i].Length);
        }

        Console.WriteLine(string.Join(",", sortedArray));

        for (int i = 0; i < sortedArray.Count; i++)
        {
            tmpArray[i] = sortedArray[i];
        }
        Array.Sort(tmpArray);
        Console.WriteLine(string.Join(",", tmpArray));

        for (int i = 0; i < tmpArray.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (tmpArray[i] == array[j].Length) //// && sortArray[count] == null)
                {
                    if (count<= array.Length-1)
                    {
                        sortArray[count] = array[j];
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
        }

        Console.WriteLine(string.Join(",", sortArray));
    }
}