using System;


class MargeSort3
{
    static void Main()
    {
        //input
        int[] numbers = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5 };
        int[] temp = new int[numbers.Length];

        //output
        Console.WriteLine("Before sorting:  {0}", string.Join(",", numbers));

        MargeSort(numbers, temp, 0, numbers.Length - 1);

        Console.WriteLine("After sorting:  {0}", string.Join(",", numbers));
    }

    //metod na razdelqne na masiwa do edin element
    static void MargeSort(int[] array, int[] tmp, int start, int end)
    {
        //Array with 1 element
        if (start >= end)
        {
            return;
        }

        //Define of middle of the array
        int middle = start + (end - start) / 2;

        MargeSort(array, tmp, start, middle);
        MargeSort(array, tmp, middle + 1, end);

        CompareAndSort(array, tmp, start, middle, end);
    }

    static void CompareAndSort(int[] array, int[] tmp, int start, int middle, int end)
    {
        int left_tmp = start;
        int left_arr = start;
        int middle_arr = middle + 1;

        while (left_arr <= middle && middle_arr <= end)
        {
            if (array[left_arr] > array[middle_arr])
            {
                tmp[left_tmp++] = array[middle_arr++];
            }
            else
            {
                tmp[left_tmp++] = array[left_arr++];
            }
        }

        while (left_arr <= middle)
        {
            tmp[left_tmp++] = array[left_arr++];
        }

        while (middle_arr <= end)
        {
            tmp[left_tmp++] = array[middle_arr++];
        }
        for (int i = start; i <= end; i++)
        {
            array[i] = tmp[i];
        }
    }
}