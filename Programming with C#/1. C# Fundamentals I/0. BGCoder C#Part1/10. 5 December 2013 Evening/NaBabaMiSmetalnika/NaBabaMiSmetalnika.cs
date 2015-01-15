using System;

class NaBabaMiSmetalnika
{
    static void Main()
    {
        Console.BufferHeight = 7000;

        int n = int.Parse(Console.ReadLine());


        int[,] matrix = new int[8, n];

        int[] testNumber = new int[n];
        ;

        for (int row0 = 0; row0 < matrix.GetLength(0); row0++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int col0 = 0; col0 < matrix.GetLength(1); col0++)
            {
                matrix[row0, matrix.GetLength(1) - 1 - col0] = (number >> col0) & 1;
            }
        }

        //print
        PrintMatrix(matrix, n);

        //solution
        string comand = String.Empty;
        int row = 0;
        int col = 0;
        int pos;

        while (comand != "stop")
        {
            comand = Console.ReadLine();

            if (comand == "left")
            {
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());

                if (col < 0)
                {
                    col = 0;
                }

                if (col > n)
                {
                    col = n - 1;
                }

                col++;
                col = n -1- col;  // campare position
                pos = 0;
                for (int i = col; i< n; i++)
                {
                    if (matrix[row, i] == 1)
                    {
                        if (matrix[row, i] == 1)
                        {
                            matrix[row, i] = 0;
                            matrix[row, pos] = 1;
                            pos++;
                            while (matrix[row, pos] == 1)
                            {
                                pos++;
                            }
                        }    
                    }
                }

                //print
                PrintMatrix(matrix, n);

            }

            

            if (comand == "right")
            {
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());

                if (col < 0)
                {
                    col = 0;
                }

                if (col > n)
                {
                    col = n-1;
                }

                col++;
                col = n - col;  // campare position
                pos = n-1;
                for (int i = 0; i <= col; i++)
                {
                    if (matrix[row, i] == 1 && pos > i)
                    {
                        matrix[row, i] = 0;
                        matrix[row, pos] =1;
                        pos--;
                        while ( matrix[row, pos] == 1)
                        {
                            pos--;
                        }
                    }
                        
                }

                //print
                PrintMatrix(matrix, n);

            }

            

            if (comand == "reset")
            {
                for (int m = 0; m < 8; m++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (matrix[m, i] == 1) // && i < n)
                        {
                            for (int j = n - 1; j >= 0; j--)
                            {
                                if (matrix[m, j] == 0 && matrix[m, i] == 1)
                                {
                                    matrix[m, j] = 1;
                                    matrix[m, i] = 0;
                                    i++;
                                    if (i > 31)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                //print
                PrintMatrix(matrix, n);
            }
        }

        

        // result
        int result = CalcRowNumber(n, matrix);

        int count = 0;
        for (int col3 = 0; col3 < matrix.GetLength(1); col3++)
        {
            int tempCount = 0;
            for (int row3 = 0; row3 < 8; row3++)
            {
                if (matrix[row3, col3] == 0)
                {
                    tempCount++;
                }
            }

            if (tempCount == 8)
            {
                count++;
            }
        }

        Console.WriteLine(result * count);
    }

    private static int CalcRowNumber(int n, int[,] matrix)
    {
        int result = 0;
        for (int row2 = 0; row2 < matrix.GetLength(0); row2++)
        {
            for (int col2 = n - 1; col2 >= 0; col2--)
            {
                result += matrix[row2, col2] * (int) Math.Pow(2, n - 1 - col2);
            }

            // Console.WriteLine();
            Console.WriteLine(result);
        }
        return result;
    }

    private static void PrintMatrix(int[,] matrix, int n)
    {
        int row2 = 0;
        for (int row1 = 0; row1 < matrix.GetLength(0); row1++)
        {
            for (int col1 = 0; col1 < matrix.GetLength(1); col1++)
            {
                if (matrix[row1, col1] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row1, col1] == 1)
                {
                    Console.Write('*');
                }
            }

            Console.Write(" ");
            int result = 0;          
            for (int col2 = n - 1; col2 >= 0; col2--)
            {
                Console.Write("{0}", matrix[row2, col2]);
                result += matrix[row2, col2] * (int) Math.Pow(2, n - 1 - col2);
            }

            row2++;
            Console.WriteLine(" --> {0}", result);

            Console.WriteLine();
        }
    }
}