using System;
//Write a program that finds the most frequent number in an array. Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


class MostFrequentNumber
{
    static void Main()
    {
        //input
        Console.Write("Enter the array size(n): ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];//{ 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 }; 

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //check input
        Console.WriteLine(string.Join(",", array));
        Console.WriteLine();

        //logic
        int currNumber = 0;
        int number = 0;
        int maxSequence = 0;
        int currSequence = 1;

        for (int j = 0; j < array.Length; j++)
        {
            currNumber = array[j];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (currNumber == array[i])
                {
                    currSequence++;
                }
                if (currSequence > maxSequence)
                {
                    maxSequence = currSequence;
                    number = currNumber;
                }
            }
            currSequence = 0;
        }
       
        //output
        Console.WriteLine("The number is: {0}({1} time)", number, maxSequence);
    }
}