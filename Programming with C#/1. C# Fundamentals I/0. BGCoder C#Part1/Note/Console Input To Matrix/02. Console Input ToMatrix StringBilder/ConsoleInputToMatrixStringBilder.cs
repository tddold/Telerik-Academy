using System;
using System.Text;

class ConsoleInputToMatrixStringBilder
{
    static void Main()
    {
        int n = 8;
        int[,] matrix = new int[n, n];

        // Input
        for (int row = 0; row < n; row++)
        {
            int num = int.Parse(Console.ReadLine());
            string numToString = Convert.ToString(num, 2).PadLeft(n, '0');
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = int.Parse(numToString[col].ToString());
            }
        }

        //Solution

        // Output
        for (int row = 0; row < n; row++)
        {
            StringBuilder sb = new StringBuilder();
            for (int col = 0; col < n; col++)
            {
                sb.Append(matrix[row, col]);
            }

            int num = Convert.ToInt32(sb.ToString(), 2);
            Console.Write(num);
        }

        Console.WriteLine();
    }
}