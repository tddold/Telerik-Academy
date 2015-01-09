using System;
////  Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
////7 11 14 16
////4  8 12 15
////2  5  9 13
////1  3  6 10 

class CreateAndPrintNmatrix_Var4
{
    public static void PrinMatrix(int[,] matrix)
    {
        int size = (int)Math.Log10(matrix.Length) + 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(Convert.ToString(matrix[i, j]).PadRight(size, ' ') + (j != matrix.GetLength(1) - 1 ? " " : "\n"));
            }
        }
    }


    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int counter = 1;

        for (int i = 0; i <= n - 1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                matrix[n - i + j - 1, j] = counter++;
            }
        }

        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {
                matrix[i - j, n - j - 1] = counter++;
            }
        }

        ////output
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0, 3}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        PrinMatrix(matrix);
    }

}
