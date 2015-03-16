/*Problem 8. Matrix
 * Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
 * 
 * Problem 9. Matrix indexer
 *  Implement an indexer this[row, col] to access the inner matrix cells.
 *  
 * Problem 10. Matrix operations
 *  Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix
 *  multiplication.Throw an exception when the operation cannot be performed.
 *  Implement the true operator (check for non-zero elements).*/

namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Matrix");
            PrintSeparateLine();

            Matrix<int> matrix1 = new Matrix<int>(3, 3,
                10, 11, 12,
                13, 14, 15,
                16, 17, 18);

            Console.WriteLine("\nPrint matrix1 with params:");

            Console.WriteLine(matrix1);

            Console.WriteLine("\nPrint matrix2 with params:");

            var matrix2 = new Matrix<int>(3, 3,
                1, 2, 3,
                4, 5, 6,
                7, 8, 9);

            Console.WriteLine(matrix2);
            PrintSeparateLine();

            Console.WriteLine("\nAccumulate two matrix");
            Console.WriteLine(matrix1 + matrix2);
            PrintSeparateLine();

            Console.WriteLine("\nSubtracting the two matrix");
            Console.WriteLine(matrix1 - matrix2);
            PrintSeparateLine();

            Console.WriteLine("\nMultiplying the two matrix");
            Console.WriteLine(matrix1 * matrix2);
            PrintSeparateLine();

            Console.WriteLine("\nTrue operator");

            Console.WriteLine("First matrix: {0}", matrix1 ? "Non-empty!" : "Empty!");
            Console.WriteLine("New matrix:   {0}\n", new Matrix<double>(1, 1) ? "Non-empty!" : "Empty!");
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
