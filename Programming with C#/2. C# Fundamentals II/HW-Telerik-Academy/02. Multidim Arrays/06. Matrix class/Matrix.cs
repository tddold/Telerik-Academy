using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Matrix_class
{
    class Matrix
    {
        //Fields
        public int Rows;
        public int Cols;
        private int[,] matrix;

        // Constructors
        public Matrix(int rows, int cols)
            : this(rows, cols, new int[] { })
        {

        }

        public Matrix(int rows, int cols, params int[] numbers)
        {
            if (rows * cols != numbers.Length && numbers.Length != 0)
            {
                throw new ArgumentException();
            }

            this.matrix = new int[rows, cols];
            this.Rows = rows;
            this.Cols = cols;

            if (numbers.Length > 0)
            {
                Buffer.BlockCopy(numbers, 0, matrix, 0, rows * cols * sizeof(int));
            }
        }

        // Indexers for accessing the matrix content
        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        // Override method ToString() to print appropriately matrix elements
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            //  string result = String.Empty;

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.AppendFormat("{0,4}", this.matrix[row, col]);
                    // result += matrix[row, col] + " ";
                }

                result.AppendLine();
                // result += Environment.NewLine;
            }

            return result.ToString();
        }

        // Accumulation (m1 + m2)
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                Console.WriteLine("-> Invalid operation! Matrices must be of one and same type...");
                return null;
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = matrix1[row, col] + matrix2[row, col];
                }
            }

            return result;
        }

        // Substraction (m1 - m2)
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                Console.WriteLine("-> Invalid operation! Matrices must be of one and same type...");
                return null;
            }

            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = matrix1[row, col] - matrix2[row, col];
                }
            }

            return result;
        }

        // Multiplication (m1 * m2)
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            //if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            //{
            //    Console.WriteLine("-> Invalid operation! Matrices must be of one and same type...");
            //    return null;
            //}

            Matrix result = new Matrix(matrix1.Rows, matrix1.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    for (int k = 0; k < matrix1.Cols; k++)
                    {
                        result[row, col] += matrix1[row, k] * matrix2[k, col];
                    }
                }
            }

            return result;
        }
    }
}
