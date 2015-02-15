/*Problem 3. Sequence n matrix
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:

matrix	                result		 ||   matrix	         result
ha	fifi    ho	hi      ha, ha, ha   ||   s	    qq	s        s, s, s
fo	 ha	    hi	xx                   ||   pp	pp	s
xxx	 ho	    ha	xx                   ||   pp	qq	s
*/

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Enter the rows of the matrix : ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the cols of the matrix : ");
        int cols = int.Parse(Console.ReadLine());
        PrintSeparateLine();

        string[,] matrix = new string[rows, cols];
        Console.WriteLine("Enter the strings element of the matrix:\n");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(" matrix[{0}, {1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        PrintSeparateLine();
        Console.WriteLine("Your matrix is : ");
        PrintMatrix(matrix);
        PrintSeparateLine();

        // logic
        string element = String.Empty;
        int maxSequence = 0;

        FindLongestSequence(matrix, ref element, ref maxSequence);

        // Print result
        PrinArray(maxSequence, element);
        PrintSeparateLine();

    }

    private static void FindLongestSequence(string[,] matrix, ref string element, ref int maxSequence)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                // Check diagonals
                int currRow = row;
                int currCol = col;
                int tempSequence = 1;

                if (currCol < matrix.GetLength(1) - 1 && currRow < matrix.GetLength(0) - 1)
                {
                    while (matrix[currRow, currCol] == matrix[currRow + 1, currCol + 1])
                    {
                        currRow++;
                        currCol++;
                        tempSequence++;
                        if (tempSequence > maxSequence)
                        {
                            maxSequence = tempSequence;
                            element = matrix[row, col];

                        }

                        if (currRow == matrix.GetLength(0) - 1)
                        {
                            break;
                        }

                        if (currCol == matrix.GetLength(1) - 1)
                        {
                            break;
                        }
                    }
                }

                // Check colums
                currRow = row;
                currCol = col;
                tempSequence = 1;

                if (currRow < matrix.GetLength(0) - 1)
                {
                    while (matrix[currRow, currCol] == matrix[currRow + 1, currCol])
                    {
                        currRow++;
                        tempSequence++;

                        if (tempSequence > maxSequence)
                        {
                            maxSequence = tempSequence;
                            element = matrix[row, col];

                        }

                        if (currRow == matrix.GetLength(0) - 1)
                        {
                            break;
                        }
                    }
                }

                // Check rows
                currRow = row;
                currCol = col;
                tempSequence = 1;

                if (currCol < matrix.GetLength(1) - 1)
                {
                    while (matrix[currRow, currCol] == matrix[currRow, currCol + 1])
                    {
                        currCol++;
                        tempSequence++;

                        if (tempSequence > maxSequence)
                        {
                            maxSequence = tempSequence;
                            element = matrix[row, col];

                        }

                        if (currCol == matrix.GetLength(1) - 1)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }

    static void PrinArray(int maxSequence, string element)
    {
        Console.WriteLine("The max sequence is : {0}", maxSequence);
        string[] array = new string[maxSequence];
        for (int i = 0; i < maxSequence; i++)
        {
            array[i] = element;
        }
        Console.WriteLine(string.Join(",", array));
    }

    private static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}