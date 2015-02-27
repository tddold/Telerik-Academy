/*Problem 5. Maximal area sum
Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
Example:

|input	    |output
|4 
|2 3 3 4 
|0 2 3 4 
|3 7 1 2 
|4 3 3 2	|17
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class MaximalAreaSum
{
    static int[,] matrix;
    static int size;

    static void Main()
    {
        Console.WriteLine("Problem 5. Maximal area sum");
        PrintSeparateLine();

        string path = "../../file.txt";

        ReadInput(path);
        PrintInputMatrix();
        Console.WriteLine("\n> Result: {0}", GetMaxAreaSum());
        PrintSeparateLine();
    }

    private static int GetMaxAreaSum()
    {
        int result = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > result)
                {
                    result = sum;
                }
            }
        }

        return result;
    }

    public static void ReadInput(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            size = int.Parse(reader.ReadLine());
            matrix = new int[size, size];
            ;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = reader.ReadLine()
                .Split(new char[] { '\t', ' ', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }

    private static void PrintInputMatrix()
    {
        Console.WriteLine("\n> Input matrix: ");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("\t\t");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 2}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }
}