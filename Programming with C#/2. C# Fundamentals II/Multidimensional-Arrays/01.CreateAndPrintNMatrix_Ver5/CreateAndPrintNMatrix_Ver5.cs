using System;
////  Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
////1 12 11 10
////2 13 16  9
////3 14 15  8
////4  5  6  7 

class CreateAndPrintNMatrix_Ver5
    {
    static void PrintMatrix(int[,] matrix)
        {
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                Console.Write("{0, 3}", matrix[i, j]);
                }

            Console.WriteLine();
            }
        }

    static void Main()
        {
        ////input
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        bool up = false;
        bool down = true;
        bool left = false;
        bool rigth = false;
        int row = 0;
        int col = 0;
        int maxRaotation = (int)Math.Pow(n, 2);

        for (int i = 1; i < maxRaotation + 1; i++)
            {
            if (up)
                {
                matrix[row, col] = i;
                row--;
                if (row == -1 || matrix[row, col] != 0)
                    {
                    row++;
                    up = false;
                    left = true;
                    col--;
                    continue;
                    }
                }

            if (down)
                {
                matrix[row, col] = i;
                row++;
                if (row == n || matrix[row, col] != 0)
                    {
                    row--;
                    down = false;
                    rigth = true;
                    col++;
                    continue;
                    }
                }

            if (rigth)
                {
                matrix[row, col] = i;
                col++;
                if (col == n || matrix[row, col] != 0)
                    {
                    col--;
                    rigth = false;
                    up = true;
                    row--;
                    continue;
                    }
                }



            if (left)
                {
                matrix[row, col] = i;
                col--;
                if (col == 0 || matrix[row, col] != 0)
                    {
                    col++;
                    left = false;
                    down = true;
                    row++;
                    continue;
                    }
                }
            }

        PrintMatrix(matrix);
        }
    }