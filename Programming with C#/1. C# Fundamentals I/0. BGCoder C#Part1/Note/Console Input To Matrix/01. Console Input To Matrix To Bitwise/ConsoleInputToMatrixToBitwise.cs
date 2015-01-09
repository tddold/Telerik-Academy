using System;

class ConsoleInputToMatrixToBitwise
{
    static void Main()
    {
        int n = 8;
        int[,] matrix = new int[n, n];

        // Input
        for (int row = 0; row < n; row++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = (num >> col) & 1;
            }
        }

        //Solution

        // Output
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}