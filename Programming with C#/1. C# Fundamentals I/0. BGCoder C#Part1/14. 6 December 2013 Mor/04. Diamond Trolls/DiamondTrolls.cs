using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Diamond_Trolls
{
    class DiamondTrolls
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int hight = 6 + (((n - 3) / 2) * 3);
            int widht = n * 2 + 1;

            int[,] matrix = new int[hight , widht];

            int currRow = n / 2 + 1;
            int currCol = 0;

            while (currRow >= 0)
            {
                matrix[currRow, currCol] = 1;
                currRow--;
                currCol++;
            }

            currRow++;
            currCol--;

            while (currCol < widht - (n+1)/2)
            {
                matrix[currRow, currCol] = 1;
                currCol++;
            }

            currCol--;

            while (currCol < widht)
            {
                matrix[currRow, currCol] = 1;
                currRow++;
                currCol++;
            }

            currRow--;
            currCol--;

            while (currRow < hight)
            {
                matrix[currRow, currCol] = 1;
                currRow++;
                currCol--;
            }

            currRow--;
            currCol++;

            while (currCol >= 0)
            {
                matrix[currRow, currCol] = 1;
                currRow--;
                currCol--;
            }

            currRow = n / 2 + 1;
            currCol = 0;

            while (currCol < widht)
            {
                matrix[currRow, currCol] = 1;
                currCol++;
            }

            currRow = 0;
            currCol = widht / 2;

            while (currRow < hight)
            {
                matrix[currRow, currCol] = 1;
                currRow++;
            }



            //print matrix
            for (int row = 0; row < hight; row++)
            {
                for (int col = 0; col < widht; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
