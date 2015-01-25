using System;

class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n;
        int hight = n;

        int[,] matrix = new int[hight, width];

        int currCol = 0;
        int currRow = 0;
        for (int row = 0; row < n / 2; row++)
        {
            matrix[row, currCol] = 1;
            matrix[row, (width - 1) - currCol] = 2;
            matrix[(hight - 1) - row, currCol] = 2;
            matrix[(hight - 1) - row, (width - 1) - currCol] = 1;
            currCol++;

        }

        for (int col = 0; col < n; col++)
        {
            currRow = n / 2;
            matrix[currRow, col] = 4;

        }

        for (int row = 0; row < n; row++)
        {
            currCol = n / 2;
            matrix[row, currCol] = 3;
        }

        currRow = n / 2;
        currCol = n / 2;

        matrix[currRow, currCol] = 5;

        // print
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('\\');
                }
                else if (matrix[row, col] == 2)
                {
                    Console.Write('/');
                }
                else if (matrix[row, col] == 3)
                {
                    Console.Write('|');
                }
                else if (matrix[row, col] == 4)
                {
                    Console.Write('-');
                }
                else if (matrix[row, col] == 5)
                {
                    Console.Write('*');
                }
            }

            Console.WriteLine();
        }
    }
}