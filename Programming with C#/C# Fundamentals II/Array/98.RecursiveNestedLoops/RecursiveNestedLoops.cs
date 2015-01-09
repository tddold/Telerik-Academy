using System;

//Recursive nested loops

class RecursiveNestedLoops
{
    static int numbersOfLoops;
    static int numberOfIterations;
    static int[] loops;

    static void Main()
    {
        Console.Write("N = ");
        numbersOfLoops = int.Parse(Console.ReadLine());

        Console.Write("K = ");
        numberOfIterations = int.Parse(Console.ReadLine());

        loops = new int[numbersOfLoops];

        NestedLoops(0);
    }

    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == numbersOfLoops)
        {
            PrintLoops();
            return;
        }

        for (int i = 1; i <= numberOfIterations; i++)
        {
            loops[currentLoop] = i;
            NestedLoops(currentLoop + 1);
        }
    }

    static void PrintLoops()
    {
        for (int j = 0; j < numbersOfLoops; j++)
        {
            Console.Write("{0} ", loops[j]);
        }
        Console.WriteLine();
    }
}