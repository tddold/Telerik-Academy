using System;
////  Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
////1 5  9 13
////2 6 10 14
////3 7 11 15
////4 8 12 16 

class CreateAndPrintNmatrix_Var3
{
    static void Main()
    {
        ////input
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];        
        bool down = true;
        int row = 0;
        int col = 0;
        int maxRotation = (int)Math.Pow(n, 2);
        ////logic
        for (int i = 1; i < maxRotation + 1; i++)
        {
            if (down)
            {
                matrix[row, col] = i;
                row++;
                if (row == n)
                {                    
                    row = 0;
                    col++;                           
                }
            }
        }

        ////outout
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                Console.Write("{0, 3}", matrix[rows, cols]);
            }

            Console.WriteLine();
        }
    }
}