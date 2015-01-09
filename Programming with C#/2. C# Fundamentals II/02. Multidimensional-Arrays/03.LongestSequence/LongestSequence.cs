using System;

////We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.Example:
////ha  fifi ho hi
////fo  ha   hi xx  -> ha, ha, ha
////xxx hp   ha xx

public class LongestSequence
{
    private static void PrintMatrix(string[,] matrix)
    {
        ////find biger of strings
        int size = int.MinValue;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                int curentSize = 0;
                for (int i = 0; i < matrix[rows, cols].Length; i++)
                {
                    curentSize++;
                }

                if (curentSize > size)
                {
                    size = curentSize;
                }
            }
        }

        ////print the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}", Convert.ToString(matrix[row, col]).PadRight(size + 1, ' '));
            }

            Console.WriteLine();
        }
    }

    private static void Main()
    {
        ////input
        Console.Write("Enter the row of the matrix is string :");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the col of the matrix is string  :");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter the element of the {0} row and {1} col : ", row, col);
                matrix[row, col] = Console.ReadLine();
            }

            Console.WriteLine();
        }
        ////string[,] matrix = {
        ////                       {"ha",  "fifi", "ho", "hi"},
        ////                       {"fo",  "ha",   "hi", "xx"},
        ////                       {"ha", "ha",   "ha", "ha"}
        ////                   };

        PrintMatrix(matrix);

        ////logic
        string elements = " ";
        int tempSequens = 1;
        int maxSequents = 0;
        int currow = 0;
        int curcol = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currow = row;
                curcol = col;

                if (currow < matrix.GetLength(0) - 1 && curcol < matrix.GetLength(1) - 1)
                {
                    while (matrix[currow, curcol] == matrix[currow + 1, curcol + 1])
                    {
                        currow++;
                        curcol++;
                        tempSequens++;
                        if (tempSequens > maxSequents)
                        {
                            maxSequents = tempSequens;
                            elements = matrix[row, col];
                        }

                        if (currow == matrix.GetLength(0) - 1)
                        {
                            break;
                        }

                        if (curcol == matrix.GetLength(1) - 1)
                        {
                            break;
                        }
                    }
                }

                tempSequens = 1;
                currow = row;
                curcol = col;
                if (currow < matrix.GetLength(0) - 1)
                {
                    while (matrix[currow, curcol] == matrix[currow + 1, curcol])
                    {
                        currow++;
                        tempSequens++;
                        if (tempSequens > maxSequents)
                        {
                            maxSequents = tempSequens;
                            elements = matrix[row, col];
                        }

                        if (currow == matrix.GetLength(0) - 1)
                        {
                            break;
                        }
                    }
                }

                tempSequens = 1;
                currow = row;
                curcol = col;
                if (curcol < matrix.GetLength(1) - 1)
                {
                    while (matrix[currow, curcol] == matrix[currow, curcol + 1])
                    {
                        curcol++;
                        tempSequens++;
                        if (tempSequens > maxSequents)
                        {
                            maxSequents = tempSequens;
                            elements = matrix[row, col];
                        }

                        if (curcol == matrix.GetLength(1) - 1)
                        {
                            break;
                        }
                    }
                }

                tempSequens = 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("The max sequens is {0}: ", maxSequents);
        string[] array = new string[maxSequents];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = elements;
        }

        Console.WriteLine(string.Join(",", array));
    }
}