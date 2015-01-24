using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 2 * n - 3;
        int hight = n;

        int[,] matrix = new int[hight, width];

        // solution

        int currRow = 0;
        int currCol = width / 2;
        while (currCol >= 0)
        {
            matrix[currRow, currCol] = 1;

            int count = 1;
            while (count <= 2 * currRow)
            {
                matrix[currRow, currCol + count] = 1;
                count++;
            }

            currRow++;
            currCol--;
        }

        currRow = hight - 1;
        currCol = width / 2;

        matrix[currRow, currCol] = 1;

        // print
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
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