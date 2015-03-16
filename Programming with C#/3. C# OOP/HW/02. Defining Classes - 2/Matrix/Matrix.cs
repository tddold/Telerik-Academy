namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;

    public class Matrix<T>
    {
        // constans
        private const uint ROW = 3;
        private const uint COL = 3;

        // Matrix of elements
        private T[,] matrix;

        // Constructor
        public Matrix()
        {
            this.matrix = new T[ROW, COL];
            this.Rows = ROW;
            this.Cols = COL;
        }

        public Matrix(uint rows, uint cols, params T[] elements)
            : this()
        {
            if (rows * cols != elements.Length && elements.Length != 0)
            {
                throw new ArgumentException();
            }

            this.matrix = new T[rows, cols];
            this.Rows = rows;
            this.Cols = cols;

            if (elements.Length > 0)
            {
                Buffer.BlockCopy(elements, 0, this.matrix, 0, (int)(rows * cols * Marshal.SizeOf(typeof(T))));
            }
        }

        // Proparties
        public uint Rows { get; set; }

        public uint Cols { get; set; }

        // Indexer
        public T this[uint indexRow, uint indexCol]
        {
            get
            {
                if (indexRow < 0 || indexCol < 0 || indexCol > this.matrix.GetLength(1) || indexRow > this.matrix.GetLength(0))
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }

                return this.matrix[indexRow, indexCol];
            }

            set
            {
                this.matrix[indexRow, indexCol] = value;
            }
        }

        // Аddition of matrices  (m1 + m2)
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            return AdditionSubtraction(matrix1, matrix2, true);
        }

        // Subtraction of matrices (m1 - m2)
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            return AdditionSubtraction(matrix1, matrix2, false);
        }

        // Multiplying the two matrix
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Cols != matrix2.Rows)
            {
                throw new ArithmeticException("Columns on the first matrix must be equal the rows on the second matrix!");
            }

            var result = new Matrix<T>(matrix1.Rows, matrix2.Cols);

            for (uint row = 0; row < result.Rows; row++)
            {
                for (uint col = 0; col < result.Cols; col++)
                {
                    for (uint i = 0; i < matrix1.Rows; i++)
                    {
                        result[row, col] += matrix1[row, i] * (dynamic)matrix2[i, col];
                    }
                }
            }

            return result;
        }

        // True operator
        public static bool operator true(Matrix<T> matrix)
        {
            return BooleanOperator(matrix, true);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return BooleanOperator(matrix, false);
        }

        // Override method ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    result.AppendFormat("{0,4}", this.matrix[row, col]);
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        // here calculate the adding or subtracting two matrix
        private static Matrix<T> AdditionSubtraction(Matrix<T> matrix1, Matrix<T> matrix2, bool p)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArithmeticException("Matrixes must be of one and same size...");
            }

            var result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (uint row = 0; row < result.Rows; row++)
            {
                for (uint col = 0; col < result.Cols; col++)
                {
                    result[row, col] = matrix1[row, col] + (p ? matrix2[row, col] : -(dynamic)matrix2[row, col]);
                }
            }

            return result;
        }

        private static bool BooleanOperator(Matrix<T> matrix, bool p)
        {
            foreach (T element in matrix.matrix)
            {
                if (!element.Equals(default(T)))
                {
                    return p;
                }
            }

            return !p;
        }
    }
}
