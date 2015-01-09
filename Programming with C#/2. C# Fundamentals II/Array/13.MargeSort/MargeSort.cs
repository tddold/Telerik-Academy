using System;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).


class MargeSort
{
    static void Main()
    {
        //input
        //Console.Write("Enter lenght of array:");
        //int n = int.Parse(Console.ReadLine());

        //int[] array = new int[n];

        //Console.Write("Enter elements of array:");
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write("Enter element [{0}]", i);
        //    array[0] = int.Parse(Console.ReadLine());
        //}
        int[] array = { 5, 3, 7, 2, 9, 1, 8, 4, 6 };

        //check array
        Console.Write(string.Join(",", array));
        Console.WriteLine();
        Console.WriteLine();

        //logic
        int start = 0;
        int end = array.Length - 1;
        int mid = (start + end) / 2;

        int[] leftArray = new int[mid];
        int[] rightArray = new int[array.Length - mid];

        //poluchavane na leftArray
        for (int i = 0; i < mid; i++)
        {
            leftArray[i] = array[i];
        }
        Console.WriteLine("Check leftArray: {0}", string.Join(",", leftArray));

        //poluchavane na rightArray
        for (int i = 0; i < array.Length - mid; i++)
        {
            rightArray[i] = array[mid + i];
        }
        Console.WriteLine("Check rightArray:{0}", string.Join(",", rightArray));
        Console.WriteLine();

        //sort left array
        for (int i = 0; i < leftArray.Length; i++)
        {
            for (int j = i + 1; j < leftArray.Length; j++)
            {
                if (leftArray[i] > leftArray[j])
                {
                    int tmp = leftArray[j];
                    leftArray[j] = leftArray[i];
                    leftArray[i] = tmp;
                }
            }
        }
        Console.WriteLine("Check sort leftArray: {0}", string.Join(",", leftArray));

        //sort right array
        for (int i = 0; i < rightArray.Length; i++)
        {
            for (int j = i + 1; j < rightArray.Length; j++)
            {
                if (rightArray[i] > rightArray[j])
                {
                    int tmp = rightArray[j];
                    rightArray[j] = rightArray[i];
                    rightArray[i] = tmp;
                }
            }
        }
        Console.WriteLine("Check sort rightArray:{0}", string.Join(",", rightArray));

        //sort array - sravnqvame dvata sortirani masiva
        int k = 1;

        for (int i = 0; i < mid; i++, k = k + 2)
        {

            if (leftArray[i] > rightArray[i])
            {
                array[k - 1] = rightArray[i];
                array[k] = leftArray[i];
                continue;
            }
            else
            {
                array[k - 1] = leftArray[i];
                array[k] = rightArray[i];
                continue;
            }

        }
        if (leftArray.Length > rightArray.Length)
        {
            array[array.Length - 1] = leftArray[leftArray.Length - 1];
        }
        else
        {
            array[array.Length - 1] = rightArray[rightArray.Length - 1];
        }

        //output
        Console.WriteLine();
        Console.WriteLine("Sort array is:{0}", string.Join(",", array));
    }
}