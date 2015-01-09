using System;

//Write a program that finds the maximal sequence of equal elements in an array.


class SequenceEqualElements
{
    static void Main()
    {
        //input
        //Console.Write("Lenht first array:");
        //int n1 = int.Parse(Console.ReadLine());


        int sequensElements = 1;
        int sequensElements1 = 1;
        int earleyElements = 0;
        int[] checkArray = { 1, 2, 2, 4, 2, 2, 2, 2, 8, 8, 8, 2, 2, 2, 2, 2 }; //new char[n1];

        //check array
        Console.WriteLine(string.Join(",", checkArray));

        //logic
        earleyElements = checkArray[0];

        for (int i = 1; i < checkArray.Length; i++ )
        {
                if (earleyElements == checkArray[i])
                {
                    sequensElements++;
                }
                else
                {
                    if (sequensElements > sequensElements1)
                    {
                        sequensElements1 = sequensElements;
                    }
                    sequensElements = 1;
                }
                earleyElements = checkArray[i];
        }

        //output
        if (sequensElements > sequensElements1)
        {
            Console.WriteLine(sequensElements);
        }
        else
        {
            Console.WriteLine(sequensElements1);
        }
    }
}