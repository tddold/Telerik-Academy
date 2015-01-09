using System;

/*Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
*/

class MatrixUI
{
    static void Main()
    {
        Matrix matrixFirst = new Matrix(2, 2);
        matrixFirst[0, 0] = 1;
        matrixFirst[1, 1] = -12;

        Matrix matrixSecond = new Matrix(2, 2);
        matrixSecond[1, 1] = 24;

        Matrix sum = matrixFirst + matrixSecond;

        Matrix substr = matrixFirst - matrixSecond;

        Matrix multipl = matrixFirst * matrixSecond;

        /*PrintMatrix(sum);*/

        Console.WriteLine(sum.ToString());

        Console.WriteLine(substr.ToString());

        Console.WriteLine(multipl.ToString());
    }
}