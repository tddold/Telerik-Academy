using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 2 * n;
        int hight = n + 1;
        int widthTop = n;

        int[,] matrix = new int[hight, width];

        // logic
        int currRow = 0;
        int currCol = 0;
        for (int row = 0; row < hight; row++)
        {
            matrix[(hight - 1) - row, currCol] = 1;
            currCol++;
        }

        for (int col = 0; col < width; col++)
        {
            if (col>= widthTop)
            {
                matrix[currRow, col] = 1;
            }

            matrix[hight-1, col] = 1;
            
            currCol++;
        }

        currCol = width - 1; 
        for (int row = 0; row < hight; row++)
        {
            matrix[row, currCol] = 1;
        }


        // print
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
            }

            Console.WriteLine();
        }
    }
}