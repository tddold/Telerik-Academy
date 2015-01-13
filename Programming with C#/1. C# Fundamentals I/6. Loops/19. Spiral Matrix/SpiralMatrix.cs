/*Problem 19.** Spiral Matrix
Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.*/

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Title = "Spiral Matrix";

        Console.Write("Enter number between [1-20]: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('-', 40));

        int[,] matrix = new int[n, n];
        string direction = "right";
        int row = 0;
        int col = 0;

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "right" && (col >= n || matrix[row, col] != 0))
            {
                col--;
                row++;
                direction = "down";
            }
            else if (direction == "down" && (row >= n || matrix[row, col] != 0))
            {
                row--;
                col--;
                direction = "left";
            }
            else if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                col++;
                row--;
                direction = "up";
            }
            else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                row++;
                col++;
                direction = "right";
            }

            matrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            else if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col--;
            }
            else if (direction == "up")
            {
                row--;
            }
        }

        // Print matrix
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }

            Console.WriteLine();
        }
    }
}