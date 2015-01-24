using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n;
        int hight = n;

        int[,] matrix = new int[hight, width];

        // solution
        int currRow = 1;
        int currCol = n / 2 - 1;

        while (currRow <= hight / 2 - 1)
        {
            for (int i = currCol; i <= (n / 2 + currRow); i++)
            {
                matrix[currRow, i] = 3;
            }

            currRow++;
            currCol--;
        }

        currRow = hight / 2;
        currCol = 1;

        while (currRow <= hight - 1)
        {
            
            for (int i = currCol; i <= width-2; i++)
            {
                matrix[currRow, i] = 3;
            }

            width--;
            currRow++;
            currCol++;
        }

        width = n;
        int currNumber = 6;
        int countRhomb = 2;
        int count = 0;
        while (currNumber <=n)
        {
            if (count == 2)
            {
                countRhomb++;
                count = 0;
            }
            count++;
            currNumber += 2;
        }

        for (int i = 0; i < countRhomb; i++)
        {
            currRow = n / 2 - 1;
            currCol = 2 * i;

            while (currRow >= 2 * i)
            {
                matrix[currRow, currCol] = 1;
                currRow--;
                currCol++;
            }

            currRow++;

            while (currCol <= (width - 1) - 2 * i)
            {
                matrix[currRow, currCol] = 2;
                currRow++;
                currCol++;
            }
           
            currCol--;

            while (currRow <= (hight - 1) - (2 * i))
            {
                matrix[currRow, currCol] = 1;
                currRow++;
                currCol--;
            }

            currRow--;

            while (currCol >= 2 * i)
            {
                matrix[currRow, currCol] = 2;
                currRow--;
                currCol--;
            }
        }

        //matrix[n / 2 - 1, n / 2 - 1] = 1;
        //matrix[n / 2 - 1, n / 2] = 2;
        //matrix[n / 2, n / 2 - 1] = 2;
        //matrix[n / 2 , n / 2] = 1;

        // print
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write("/");
                }
                else if (matrix[row, col] == 2)
                {
                    Console.Write("\\");
                }
                else if (matrix[row, col] == 3)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}