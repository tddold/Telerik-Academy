using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bat_Goiko_Tower
{
    class BatGoikoTower
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int hight = n;
            int width = 2 * n;

            int[,] matrix = new int[hight, width];

            // logic
            int currRow;
            int currCol = n - 1;
            for (int row = 0; row < hight; row++)
            {
                matrix[row, currCol] = 1;
                currCol--;
            }

            currCol = n;
            for (int row = 0; row < hight; row++)
            {
                matrix[row, currCol] = 2;
                currCol++;
            }

            currRow = 1;
            currCol = n - 1;
            int countRow = 1;

            while (currRow < hight)
            {
                countRow++;
                while (currCol >= n - currRow && currCol < n + currRow)
                {
                    matrix[currRow, currCol] = 3;
                    currCol++;
                }

                currRow += countRow;
                currCol = n - currRow;
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
                        Console.Write('/');
                    }
                    else if (matrix[row, col] == 2)
                    {
                        Console.Write('\\');
                    }
                    else if (matrix[row, col] == 3)
                    {
                        Console.Write('-');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
