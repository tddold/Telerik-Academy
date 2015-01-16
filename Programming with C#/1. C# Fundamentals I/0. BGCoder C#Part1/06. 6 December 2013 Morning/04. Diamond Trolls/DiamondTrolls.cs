using System;

class DiamondTrolls
{
    static void Main()
    {
        // input

        int n = int.Parse(Console.ReadLine());

        int width = n * 2 + 1;
        int hight = 6 + ((n - 3) / 2) * 3;

        int[,] matrix = new int[hight, width];

        // logic

        int currentRow = n / 2 + 1;
        int currentCol = 0;

        while (currentRow >= 0)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow--;
            currentCol++;
        }

        currentRow++;
        currentCol--;

        while (currentCol <= ((width - 1 + n) / 2))
        {
            matrix[currentRow, currentCol] = 1;
            currentCol++;
        }

        currentCol--;

        while (currentCol <= width - 1)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow++;
            currentCol++;
        }

        currentRow--;
        currentCol--;

        while (currentRow < hight)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow++;
            currentCol--;
        }

        currentRow--;
        currentCol++;

        while (currentCol >= 0)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow--;
            currentCol--;
        }

        currentRow = n / 2 + 1;
        currentCol = 1;

        while (currentCol <= width - 2)
        {
            matrix[currentRow, currentCol] = 1;
            currentCol++;
        }

        currentRow = 1;
        currentCol = n;

        while (currentRow <= hight - 2)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow++;
        }

        // print
        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }
    }
}