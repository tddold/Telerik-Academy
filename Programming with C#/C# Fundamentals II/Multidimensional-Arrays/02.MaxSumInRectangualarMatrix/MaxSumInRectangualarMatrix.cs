using System;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


class MaxSumInRectangualarMatrix
{
    static void PrintMatix(int[,] matrix)
    {
        int size = (int)Math.Log10(matrix.Length) + 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(Convert.ToString(matrix[i, j]).PadRight(size, ' ') + (j != matrix.GetLength(1) - 1 ? " " : "\n"));
            }
        }
    }

    static void Main()
    {
        ////input
        //Console.Write("Enter N: ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Enter M: ");
        //int m = int.Parse(Console.ReadLine());
        //// int[,] matrix = new int[n, m];
        int bestSum = int.MinValue;
        int platformMaxX = 2;
        int platformMaxY = 2;
        int curentSum = 0;
        Random rand = new Random();

        ///logic
        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        matrix[i, j] = rand.Next(1, 101);
        //    }
        //}

        int[,] matrix = {
          {7, 1, 3, 3, 2, 1},
          {1, 3, 9, 8, 5, 6},
          {4, 6, 7, 9, 1, 0} };


        for (int i = 0; i < matrix.GetLength(0) - (platformMaxX - 1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - (platformMaxY - 1); j++)
            {
                //i, j start of the platforms
                for (int platformX = 0; platformX < i + platformMaxX; platformX++)
                {
                    for (int platformY = 0; platformY < j + platformMaxY; platformY++)
                    {
                        curentSum += matrix[platformX, platformY];
                    }

                }
                if (curentSum > bestSum)
                {
                    bestSum = curentSum;
                }
            }
        }

        Console.WriteLine(bestSum);

        PrintMatix(matrix);
    }
}