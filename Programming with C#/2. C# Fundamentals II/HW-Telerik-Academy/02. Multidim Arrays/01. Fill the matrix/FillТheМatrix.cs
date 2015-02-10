/*Problem 1. Fill the matrix
Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:
  a) 1 5  9 13   b) 1 8  9 16    c) 7 11 14 16  d)* 1 12 11 10
 *   2 6 10 14      2 7 10 15       4  8 12 15      2 13 16  9
 *   3 7 11 15      3 6 11 14       2  5  9 13      3 14 15  8
 *   4 8 12 16      4 5 12 13       1  3  6 10      4  5  6  7 
*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class FillТheМatrix
{
    static int[,] matrix;

    static void Main()
    {
        Console.Title = "Problem 1. Fill the matrix";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Problem 1. Fill the matrix!");
        PrintSeparateLine();

        Console.Write("Enter the size of the array: n = ");
        int n = int.Parse(Console.ReadLine());

        matrix = new int[n, n];

        // a) Variant
        matrix = FirstMatrix(n);
        PrintMatrix(matrix);
        PrintSeparateLine();

        // b) Variant
        matrix = SecondMatrix(n);
        PrintMatrix(matrix);
        PrintSeparateLine();

        // c) Variant
        matrix = ThirdMatrix(n);
        PrintMatrix(matrix);
        PrintSeparateLine();

        // d) Variant
        matrix = FourthMatrix(n);
        PrintMatrix(matrix);
        PrintSeparateLine();
    }

    static int[,] FirstMatrix(int n)
    {
        int count = 0;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                count++;
                matrix[row, col] = count;
            }
        }

        return matrix;
    }

    static int[,] SecondMatrix(int n)
    {
        int count = 0;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                count++;
                if (col % 2 == 0)
                {
                    matrix[row, col] = count;
                }
                else
                {
                    matrix[(n - 1) - row, col] = count;
                }
            }
        }

        return matrix;
    }

    static int[,] ThirdMatrix(int n)
    {
        int count = 1;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                matrix[n - row + col - 1, col] = count++;
            }
        }

        for (int row = n - 2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                matrix[row - col, n - col - 1] = count++;
            }
        }

        return matrix;
    }

    static int[,] FourthMatrix(int n)
    {
        int count = 1, row = 0, col = 0;
        string direction = "down";
        matrix = new int[n, n];

        while (count <= n * n)
        {
            if (direction == "down")
            {
                while (row < n && matrix[row, col] == 0)
                {
                    matrix[row, col] = count++;
                    row++;
                }

                direction = "right";
                row--;
                col++;
            }
            else if (direction == "right")
            {
                while (col < n && matrix[row, col] == 0)
                {
                    matrix[row, col] = count++;
                    col++;
                }

                direction = "up";
                col--;
                row--;
            }
            else if (direction == "up")
            {
                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = count++;
                    row--;
                }

                direction = "left";
                row++;
                col--;
            }
            else if (direction == "left")
            {
                while (col > 0 && matrix[row, col] == 0)
                {
                    matrix[row, col] = count++;
                    col--;
                }

                direction = "down";
                col++;
                row++;
            }
        }

        return matrix;
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