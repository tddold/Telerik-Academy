using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] spiral = new int[n, n];

        string direction = "right";

        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= n * n; i++)
        {
            // Check limits matrix
            CheckLimitsSpiralMatrix(n, spiral, ref direction, ref currentRow, ref currentCol);

            spiral[currentRow, currentCol] = i;

            // Get new direction
            GetDirection(direction, ref currentRow, ref currentCol);

        }

        //prin Matrix
        PrintMatrix(n, spiral);
    }

    private static void CheckLimitsSpiralMatrix(int n, int[,] spiral, ref string direction, ref int currentRow, ref int currentCol)
    {
        if (direction == "right" && (currentCol >= n || spiral[currentRow, currentCol] != 0))
        {
            currentCol--;
            currentRow++;
            direction = "down";
        }
        else if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] != 0))
        {
            currentRow--;
            currentCol--;
            direction = "left";
        }
        else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
        {
            currentCol++;
            currentRow--;
            direction = "up";
        }
        else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
        {
            currentRow++;
            currentCol++;
            direction = "right";
        }
    }

    private static void PrintMatrix(int n, int[,] spiral)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 4}", spiral[i, j]);
            }
            Console.WriteLine();
        }
    }

    private static void GetDirection(string direction, ref int currentRow, ref int currentCol)
    {
        if (direction == "right")
        {
            currentCol++;
        }
        else if (direction == "down")
        {
            currentRow++;
        }
        else if (direction == "left")
        {
            currentCol--;
        }
        else if (direction == "up")
        {
            currentRow--;
        }
    }
}