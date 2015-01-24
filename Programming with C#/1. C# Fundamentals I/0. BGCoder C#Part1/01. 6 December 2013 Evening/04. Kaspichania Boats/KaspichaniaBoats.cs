using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = (n * 2) + 1;
        int hight = 6 + ((n - 3) / 2) * 3;

        int[,] matrix = new int[hight, width];

        // solution

        int currRow = n - 1;
        int currCol = 1;

        while (currRow >= 0)
        {
            matrix[currRow, currCol] = 1;
            currRow--;
            currCol++;
        }

        currRow++;
        currCol--;

        while (currCol < width -1)
        {
            matrix[currRow, currCol] = 1;
            currRow++;
            currCol++;
        }

        currRow = n;
        currCol = 0;

        while (currCol <= width - 1)
        {
            matrix[currRow, currCol] = 1;
            currCol++;
        }

        currRow =0;
        currCol = width / 2;

        while (currRow <=hight - 1)
        {
            matrix[currRow, currCol] = 1;
            currRow++;
        }

        currRow = n + 1;
        currCol = 1;

        while (currRow <= hight - 1)
        {
            matrix[currRow, currCol] = 1;
            currRow++;
            currCol++;
        }

        currRow = n + 1;
        currCol = width - 2;

        while (currRow <= hight - 1)
        {
            matrix[currRow, currCol] = 1;
            currRow++;
            currCol--;
        }

        currRow = hight - 1;
        currCol = hight / 3;

        while (currCol < hight / 3 + n)//(width) - ((width-1) / 3))
        {
            matrix[currRow, currCol] = 1;
           
            currCol++;
        }


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