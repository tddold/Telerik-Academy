using System;

class BatGoikoTower
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int hight = n;
        int width = 2 * n;
        int[,] matrix = new int[hight, width];

        int currentRow = n - 1;
        int currentCol = 0;

        while (currentRow >= 0)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow--;
            currentCol++;

        }

        currentRow++;

        while (currentRow <= n - 1)
        {
            matrix[currentRow, currentCol] = 2;
            currentRow++;
            currentCol++;
        }

        int countCrossbeams = 2;
        for (int row = 1; row < n; row++)
        {
            for (int col = n - row; col < 2 * n - (n - row); col++)
            {
                matrix[row, col] = 3;
            }

            if ((row += countCrossbeams) < n)
            {
                row--;
                countCrossbeams++;
            }
        }

        // print
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                else if (matrix[row, col] == 1) //  && col < n)
                {
                    Console.Write("/");
                }
                else if (matrix[row, col] == 2) // && col >= n && col < 2 * n)
                {
                    Console.Write("\\");
                }
                else if (matrix[row, col] == 3)
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine();
        }
    }
}