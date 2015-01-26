using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int hight = (n * 2) - 1;

        int[,] matrix = new int[hight, n];

        // logic
        int startCol = 0;

        for (int row = 0; row < n; row++)
        {
            matrix[row, startCol] = 1;
            matrix[(hight - 1) - row, startCol] = 1;
            startCol++;
        }

        // print
        for (int row = 0; row < hight; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write((matrix[row, col] == 0) ? '.' : '*');
            }

            Console.WriteLine();
        }
    }
}