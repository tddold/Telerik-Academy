using System;

class ReverseSpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] spiral = new int[n, n];

        string direction = "right";

        int currentRow = 0;
        int currentCol = 0;

        for (int i = n * n; i >= 1; i--)
        {
            // logic to get limits to matrix
            if (direction == "right" && (currentCol >= n || spiral[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol--;
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] !=0))
            {
                currentRow--;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] !=0))
            {
                currentRow--;
                currentCol++;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                direction = "right";
            }

            // input number to matrix
            spiral[currentRow, currentCol] = i;

            // logic to get direction
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

        // print matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 4}", spiral[i, j]);
            }

            Console.WriteLine();
        }
    }
}