using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Matrix_class
{
    class MatrixClass
    {
        static void Main()
        {
            Matrix matrix1 = new Matrix(3, 3,
                1, 2, 0,
                0, 1, 1,
                2, 0, 1 );

            Matrix matrix2 = new Matrix(3, 3,
                 1, 1, 2,
                 2, 1, 1,
                 1, 2, 1);

            Console.WriteLine("First Matrix is:");
            Console.WriteLine(matrix1);

            Console.WriteLine("Second Matrix is:");
            Console.WriteLine(matrix2);

            Console.WriteLine("Аccumulation of the Matrices:");
            Console.WriteLine(matrix1 + matrix2);

            Console.WriteLine("Subtraction of the Matrices:");
            Console.WriteLine(matrix1 - matrix2);

            Console.WriteLine("Multiplication of the Matrices:");
            Console.WriteLine(matrix1 * matrix2);
        }
    }
}
