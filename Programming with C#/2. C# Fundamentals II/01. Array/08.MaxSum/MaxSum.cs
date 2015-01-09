

using System;

class MaxSum
{
    static void Main()
    {
        //input
        Console.Write("Enter the array size(n): ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];//{ 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };        

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //check input
        Console.WriteLine(string.Join(",", array));
        Console.WriteLine();

        //logic
        int currSum = array[0];
        int subSum = 0;
        int maxSum = 0;
        int currSequence = 1;
        int maxSequence = 1;
        int start = 0;
        int tempStart = 0;

        for (int i = 1; i < array.Length; i++)
        {
            //subSum = currSum + array[i];

            if (currSum + array[i] > array[i])
            {
                currSum+=array[i];
                currSequence++;
            }
            else
            {
                currSum = array[i];
                tempStart = i;
                currSequence = 1;
            }
            if (currSum>maxSum)
            {
                maxSum = currSum;
                start = tempStart;
                maxSequence = currSequence;
            }
        }

        //output
        Console.WriteLine("The sum is:{0}", maxSum);
        for (int i = start; i < start+maxSequence; i++)
        {
            Console.Write(array[i] + ",");
        }
        Console.WriteLine();
      
        
        //int currSum = array[0];
        //int currSequence = 1;
        //int maxSequence = 1;
        //int start = 0;
        //int max = 0;
        //int startTemp = 0;
        //for (int i = 1; i < array.Length; i++)
        //{
        //    if (array[i] + currSum > array[i])
        //    {
        //        currSum += array[i];
        //        currSequence++;
        //    }
        //    else
        //    {
        //        currSum = array[i];
        //        startTemp = i;
        //        currSequence = 1;
        //    }
        //    if (currSum > max)
        //    {
        //        max = currSum;
        //        start = startTemp;
        //        maxSequence = currSequence;
        //    }
        //}
        //Console.WriteLine("The sum is : {0}", max);
        //for (int i = start; i < start + maxSequence; i++)
        //{
        //    Console.WriteLine(array[i] + " ");
        //}
    }
}