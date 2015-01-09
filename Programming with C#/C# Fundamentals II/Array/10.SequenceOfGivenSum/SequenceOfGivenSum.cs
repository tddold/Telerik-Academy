using System;
//Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	


class SequenceOfGivenSum
{
    static void Main()
    {
        //input
        Console.Write("Enter check sum S= ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter the array size(n): ");
        int n = int.Parse(Console.ReadLine());
        
        int[] array = { 4, 3, 1, 4, 2, 5, 8 }; //new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //check input
        Console.WriteLine(string.Join(",", array));
        Console.WriteLine();

        //logic
        int currSum = 0;
        int start = 0;
        int tempStart = 0;
        int sequence = 0;
        int currSequence = 0;
        bool isSum = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (currSum + array[i] == s)
            {
                start = tempStart;
                sequence = currSequence;
                isSum = true;
                break;
            }
            else if (currSum + array[i] < s)
            {
                currSum += array[i];
                currSequence++;
            }
            else if (currSum + array[i] > s)
            {
                if (i != array.Length - 1)
                {
                    tempStart = i;
                    currSum = array[i];
                    currSequence = 1;
                }
                else
                {
                    tempStart = array.Length - 2;
                    currSum = array[i - 1];
                    currSequence = 1;
                    i = array.Length - 2;
                }
            }
        }
        if (isSum == false)
        {
            sequence = 0;
        }
        else
        {
            sequence++;
        }

        //output
        Console.WriteLine("The needed sum is present in the array ----> {0}", isSum);
        Console.WriteLine("For sum S={0}", s);
        Console.Write("The sequence of elements is: {");
        for (int i = start; i < start + sequence; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write("}");
        Console.WriteLine();
        Console.WriteLine();


        //other method
        currSum = 0;
        start = 0;
        sequence = 0;
        isSum = false;
        for (int k = 0; k < array.Length; k++)
        {
            for (int l = k; l < array.Length; l++)
            {
                currSum += array[l];

                if (currSum == s)
                {
                    start = k;
                    sequence = l - k;
                    isSum = true;
                }
            }
            currSum = 0;
        }

        if (isSum==false)
        {
            sequence = 0;
        }
        else
        {
            sequence++;
        }
        //output
        Console.WriteLine("The needed sum is present in the array ----> {0}", isSum);
        Console.WriteLine("For sum S={0}", s);
        Console.Write("The sequence of elements is: {");
        for (int i = start; i < start + sequence; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write("}");
        Console.WriteLine();

    }
}