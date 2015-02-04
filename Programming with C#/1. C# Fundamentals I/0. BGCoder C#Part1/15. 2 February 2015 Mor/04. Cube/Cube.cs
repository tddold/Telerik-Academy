using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cube
{
    class Cube
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int hight = 2 * n - 1;
            int width = 2 * n - 1;
            int[,] matrix = new int[hight, width];

            int currRow = n - 2;
            int currCol = 0;

            while (currCol < n - 1)
            {
                while (currRow >= 0)
                {
                    matrix[currRow, currCol] = 1;
                    currRow--;
                }

                currRow = n - 2 - currCol;

                currCol++;
            }

            currRow = n - 2;
            currCol = 1;

            while (currRow >= 0)
            {
                matrix[currRow, currCol] = 4;
                currRow--;
                currCol++;
            }

            currRow++;
            currCol--;

            while (currCol < width)
            {
                matrix[currRow, currCol] = 4;
                currCol++;
            }

            currCol--;

            while (currRow <= n - 1)
            {
                matrix[currRow, currCol] = 4;
                currRow++;
            }

            currRow--;

            while (currCol >= n)
            {
                while (currRow < hight)
                {
                    matrix[currRow, currCol] = 1;
                    currRow++;
                }

                currRow = n + width - currCol;
                currCol--;
            }

            currRow = n - 1;
            currCol = width - 1;

            while (currRow < hight)
            {
                matrix[currRow, currCol] = 4;
                currRow++;
                currCol--;
            }

            currRow = hight - 1;
            currCol++;

            while (currCol >= 0)
            {
                matrix[currRow, currCol] = 4;
                currCol--;
            }

            currCol = 0;

            while (currRow >= n - 1)
            {
                matrix[currRow, currCol] = 4;
                currRow--;
            }

            currRow = n - 1;

            while (currCol < n)
            {
                matrix[currRow, currCol] = 4;
                currCol++;
            }

            currCol--;

            while (currCol < width)
            {
                matrix[currRow, currCol] = 4;
                currRow--;
                currCol++;
            }

            currRow = n - 1;
            currCol = n - 1;

            while (currRow < hight)
            {
                matrix[currRow, currCol] = 4;
                currRow++;
            }

            currRow = n;
            currCol = 1;

            while (currCol < n - 1)
            {
                while (currRow < hight - 1)
                {
                    matrix[currRow, currCol] = 1;
                    currRow++;
                }

                currRow = n;
                currCol++;
            }

            currRow = n - 2;
            currCol = 2;
            int count = 0;
            while (currCol <= n - 1)
            {
                while (currRow > 0)
                {
                    matrix[currRow, currCol] = 2;
                    currRow--;
                    currCol++;
                }

                count++;
                currRow = n - 2;
                currCol = 2 + count;
            }

            currRow = n - 1;
            currCol = n;
            int countRow = 1;
            int counCol = 0;

            while (currCol < width - 1)
            {
                while (currRow > countRow)
                {
                    matrix[currRow, currCol] = 3;
                    currRow--;
                    currCol++;
                }

                countRow++;
                counCol++;
                currRow = n - 1;
                currCol = n + counCol;
            }


            currRow = n - 1;
            currCol = width - 2;
            countRow = 1;
            counCol = 0;

            while (currCol > n - 1)
            {
                while (currRow < hight - 1 - countRow)
                {
                    matrix[currRow, currCol] = 3;
                    currRow++;
                    currCol--;
                }

                countRow++;
                counCol++;
                currRow = n - 1;
                currCol = width - 2 - counCol;
            }







            // print
            for (int row = 0; row < hight; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        Console.Write(" ");
                    }
                    else if (matrix[row, col] == 0)
                    {
                        Console.Write(".");
                    }
                    else if (matrix[row, col] == 2)
                    {
                        Console.Write("/");
                    }
                    else if (matrix[row, col] == 3)
                    {
                        Console.Write("X");
                    }
                    else if (matrix[row, col] == 4)
                    {
                        Console.Write(":");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
