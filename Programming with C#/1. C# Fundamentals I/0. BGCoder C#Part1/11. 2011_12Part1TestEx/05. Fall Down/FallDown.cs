using System;
using System.IO;

class FallDown
{
    const int matrixRow = 8;
    const int matrixCol = 8;
    static void Main()
    {
        //if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
        //{
        //    Console.SetIn(new StreamReader("input.txt"));
        //}

        int inputnumber = 0;
        int[,] matrix = new int[matrixRow, matrixCol];



        // input
        inputnumber = GetInputNumbers(inputnumber, matrix);

        // logic

        for (int col = 0; col < matrixCol; col++)
        {
            int countBits = 0;
            countBits = CountBitsPerColumn(matrix, col, countBits);
            while (countBits > 0 )
            {
                for (int row = 0; row < matrixRow - 1; row++)
                {
                    if (matrix[row, col] == 1 && matrix[row + 1, col] == 0)
                    {
                        matrix[row, col] = 0;
                        matrix[row + 1, col] = 1;
                    }
                }

                countBits--;
            }
        }
        
        // print
        // PrintMatrix(matrix);
       
        // output
        
        for (int row = 0; row < matrixRow; row++)
        {
            int result = 0;
            for (int col = 0; col < matrixCol; col++)
            {
                if (matrix[row, col] == 1)
                {
                    result += (int) Math.Pow(2, col);
                }
            }

            Console.WriteLine(result);
        }
    }

    private static int CountBitsPerColumn(int[,] matrix, int col, int countBits)
    {
        for (int row = 0; row < matrixRow - 1; row++)
        {
            if (matrix[row, col] == 1)
            {
                countBits++;
            }
        }
        return countBits;
    }

    private static int GetInputNumbers(int inputnumber, int[,] matrix)
    {
        for (int row = 0; row < matrixRow; row++)
        {
            inputnumber = int.Parse(Console.ReadLine());
            for (int col = 0; col < matrixCol; col++)
            {
                matrix[row, col] = ((inputnumber >> col) & 1);
            }
        }
        return inputnumber;
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrixRow; row++)
        {
            for (int col = 0; col < matrixCol; col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}