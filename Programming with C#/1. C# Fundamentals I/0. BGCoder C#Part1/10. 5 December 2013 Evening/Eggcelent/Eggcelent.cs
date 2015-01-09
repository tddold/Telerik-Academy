using System;

class Eggcelent
{
    static void Main(string[] args)
    {
        // inicialisation
        int n = int.Parse(Console.ReadLine());

        int width = 3 * n + 1;
        int eggWidth = 3 * n - 1;
        int hight = 2 * n;
        int topAndBottomEgg = n - 1;
        int verticalCount = 0;

        int[,] matrix = new int[hight, width];

        // solution
        int currentRow = 0;
        int currentCol = n + 1;

        while (true)
        {
            matrix[currentRow, currentCol] = 1;


            currentCol++;
            if (currentCol == 2 * n)
            {
                currentCol--;
                break;
            }
        }

        while (true)
        {
            matrix[currentRow, currentCol] = 1;

            currentRow++;
            currentCol += 2;
            if (currentCol == 3 * n - 1)
            {
                matrix[currentRow, currentCol] = 1;
                break;
            }
        }

        while (true)
        {
            matrix[currentRow, currentCol] = 1;

            currentRow++;
            verticalCount++;
            if (verticalCount == n - 1)
            {
                matrix[currentRow, currentCol] = 1;
                break;
            }
        }

        while (true)
        {
            matrix[currentRow, currentCol] = 1;

            currentRow++;
            currentCol -= 2;
            if (currentRow > 2 * n - 1)
            {
                currentRow--;
                currentCol += 2;
                break;
            }
        }

        while (true)
        {
            matrix[currentRow, currentCol] = 1;

            currentCol--;
            if (currentCol < n + 1)
            {
                currentCol++;
                break;
            }
        }

        while (true)
        {
            matrix[currentRow, currentCol] = 1;

            currentRow--;
            currentCol -= 2;
            if (currentCol == 1)
            {
                matrix[currentRow, currentCol] = 1;
                break;
            }
        }

        verticalCount = 0;
        while (true)
        {
            matrix[currentRow, currentCol] = 1;

            currentRow--;
            verticalCount++;

            if (verticalCount == n - 1)
            {
                matrix[currentRow, currentCol] = 1;
                break;
            }
        }

        while (true)
        {
            matrix[currentRow, currentCol] = 1;

            currentRow--;
            currentCol += 2;

            if (currentRow < 0)
            {
                currentRow++;
                currentCol -= 2;
                break;
            }
        }

        int count = 0;
        for (int i = n - 1; i < (2 * n) - (n - 1); i++)
        {
            currentRow = i;
            currentCol = 2 + count;
            while (true)
            {
                matrix[currentRow, currentCol] = 2;

                currentCol += 2;

                if (currentCol > (3 * n) - 2 - count)
                {
                    currentCol -= 2;
                    break;
                }
            }
            count++;

        }

        // printing
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
                else if (matrix[row, col] == 2)
                {
                    Console.Write('@');
                }
            }

            Console.WriteLine();
        }
    }
}