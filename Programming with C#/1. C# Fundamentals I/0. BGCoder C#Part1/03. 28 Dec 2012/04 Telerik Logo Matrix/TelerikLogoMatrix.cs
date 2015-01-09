using System;

class TelerikLogoMatrix
{
    static void Main()
    {
        // inicialization
        int x = int.Parse(Console.ReadLine());
        int y = x;
        int z = x / 2 + 1;
        int width = 2 * x + 2 * z - 3;
        int hight = width;

        string direction = "rightUp";

        int[,] matrix = new int[width, width];

        // loogic
        int currentRow = x / 2;
        int currentCol = 0;

        while (true)
        {
            matrix[currentRow, currentCol] = 1;



            if (direction == "rightUp")
            {
                if (currentRow == 0)
                {
                    direction = "rightDown";
                    continue;
                }

                currentRow--;
                currentCol++;
            }
            else if (direction == "rightDown")
            {
                if (currentCol == width-1 && currentRow == x / 2)
                {
                    break;
                }
                else if (currentRow == (2 * x) -2)
                {
                    direction = "leftDown";
                    continue;
                }

                currentRow++;
                currentCol++;
            }
            else if (direction == "leftDown")
            {
                if (currentRow == width-1)
                {
                    direction = "leftUp";
                    continue;
                }

                currentRow++;
                currentCol--;
            }
            else if (direction == "leftUp")
            {
                if (currentRow == (2 * x) - 2)
                {
                    direction = "rightUp";
                    continue;
                }

                currentRow--;
                currentCol--;
            }
        }


        // print matrix
        for (int row = 0; row < width; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }
    }
}