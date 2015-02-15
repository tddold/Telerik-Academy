/*Problem 7.* Largest area in matrix
Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
Example:

matrix	                            result
1	3	2	2	2	4               13
3	3	3	2	4	4
4	3	1	2	3	3
4	3	1	3	3	1
4	3	3	3	1	1
Hint: you can use the algorithm Depth-first search or Breadth-first search.*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class LargestAreaInMatrix
{
    static int currLenght = 0, currentNumber = 0;
    static int bestLength = 0, bestNumber = 0;
    static int[,] matrix = 
    {
        {1, 3, 2, 2, 2, 4},
        {3, 3, 3, 2, 4, 4},
        {4, 3, 1, 2, 3, 3},
        {4, 3, 1, 3, 3, 1},
        {4, 3, 3, 3, 1, 1},
    };

    static void Main()
    {
        Console.Title = "Problem 7.* Largest area in matrix";

        Console.WriteLine("Problem 7.* Largest area in matrix!");
        PrintSeparateLine();

        PrintMatrix(matrix);
        CheckMaxSequensNumber(ref bestNumber, ref bestLength);

        Console.WriteLine("Best Area of number {0} -> {1} times\n", bestNumber, bestLength);
        PrintSeparateLine();
    }

    private static void CheckMaxSequensNumber(ref int count, ref int maxSequenceNumber)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] != 0)
                {
                    currLenght = 0;
                    currentNumber = matrix[row, col];

                    ExitMatrix(row, col);

                    if (bestLength < currLenght)
                    {
                        bestLength = currLenght;
                        bestNumber = currentNumber;
                    }
                }
            }
        }
    }

    private static void ExitMatrix(int row, int col)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) ||
            col >= matrix.GetLength(1) || matrix[row, col] == 0)
        {
            return;
        }

        // recursion to explore all possible direction
        if (matrix[row, col] == currentNumber)
        {
            // mark the current cell is visited
            matrix[row, col] = 0;
            currLenght++;

            ExitMatrix(row - 1, col);
            ExitMatrix(row + 1, col);
            ExitMatrix(row, col - 1);
            ExitMatrix(row, col + 1);
        }

        return;
    }

    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("Matrix ({0}x{1}):\n", matrix.GetLongLength(0), matrix.GetLongLength(1));
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1); col++)
                Console.Write("{0,3}", matrix[row, col]);
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}