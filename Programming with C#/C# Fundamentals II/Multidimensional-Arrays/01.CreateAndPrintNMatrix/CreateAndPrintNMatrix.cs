using System;
//  Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
// 1  2  3  4
// 5  6  7  8
// 9 10 11 12
//13 14 15 16

class CreateAndPrintNMatrix
    {
    static void Main()
        {
        ////input
        Console.Write("Enter size matrix n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int count = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                matrix[i, j] = count;
                count++;
                }
            }

        ////output
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                Console.Write("{0,3}", matrix[i, j]);
                }

            Console.WriteLine();

            }

        Console.WriteLine();

        }
    }