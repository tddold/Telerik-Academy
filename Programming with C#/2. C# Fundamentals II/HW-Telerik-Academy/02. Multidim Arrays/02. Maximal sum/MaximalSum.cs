/*Problem 2. Maximal sum
Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
class MaximalSum
{
    static int[,] matrix;
    static int rowMax = 3;
    static int colMax = 3;
    static int bestSum = int.MinValue;

    static void Main()
    {
        Console.Title = "Problem 2. Maximal sum";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 2. Maximal sum");
        PrintSeparateLine();

        Console.Write("Enter row of the matrix: N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter column of the matrix: M = ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Random rand = new Random();
        matrix = new int[n, m];                              /*{
                                                            {7, 1, 3, 3, 2, 1},
                                                            {1, 3, 9, 8, 5, 6},
                                                            {4, 6, 7, 9, 1, 0}
                                                            };*/

        // random matrix for test
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rand.Next(1, 10);
            }
        }

        PrintMatrix(matrix);
        PrintSeparateLine();

        bestSum = FindMaxSum(matrix, bestSum);

        Console.WriteLine("Best sum is: {0}", bestSum);
        PrintSeparateLine();
    }

    static int FindMaxSum(int[,] matrix, int bestSum)
    {
        int currSum, bestRow = 0, bestCol = 0;
        int[,] bestMatrix = new int[rowMax, colMax];

        for (int row = 0; row < matrix.GetLength(0) - (rowMax - 1); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - (colMax - 1); col++)
            {
                currSum = 0;
                for (int currRow = row; currRow < row + rowMax; currRow++)
                {
                    for (int currCol = col; currCol < col + colMax; currCol++)
                    {
                        currSum += matrix[currRow, currCol];
                    }
                }

                if (currSum > bestSum)
                {
                    bestSum = currSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        bestMatrix = GetBestMatrix(matrix, bestRow, bestCol, bestMatrix);
        PrintMatrix(bestMatrix);

        return bestSum;
    }

    private static int[,] GetBestMatrix(int[,] matrix, int bestRow, int bestCol, int[,] bestMatrix)
    {
        for (int row = bestRow; row < bestRow + rowMax; row++)
        {
            for (int col = bestCol; col < bestCol + colMax; col++)
            {
                bestMatrix[row - bestRow, col - bestCol] = matrix[row, col];
            }
        }

        return bestMatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

}