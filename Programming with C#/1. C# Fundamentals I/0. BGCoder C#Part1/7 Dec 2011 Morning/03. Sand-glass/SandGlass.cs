using System;

class SandGlass
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int width = N;
        int hight = N;

        int[,] matrix = new int[hight, width];

        // logic
        int endRow = N / 2;
        int currRow = 0;
        int currCol = 0;

        while (currRow <= endRow)
        {
            for (int col = currCol; col < width - currCol; col++)
            {
                matrix[currRow, col] = 1;
                matrix[(hight - 1) - currRow, col] = 1;

            }

            currRow++;
            currCol++;
        }

        // print
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
            }

            Console.WriteLine();
        }
    }
}