using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Quadronacci_Rectangle
{
    class QuadronacciRectangle
    {
        static void Main()
        {
            //if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
            //{
            //    Console.SetIn(new StreamReader("input.txt"));
            //}

            // input
            List<BigInteger> arrayNumbers = new List<BigInteger>();
            for (int i = 0; i < 4; i++)
            {
                arrayNumbers.Add(BigInteger.Parse(Console.ReadLine()));
            }

            int matrixRow = int.Parse(Console.ReadLine());
            int matrixCol = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = new BigInteger[matrixRow, matrixCol];

            // solution
            BigInteger nextNumber = 0;
            int count = 0;
            int counCol = 0;
            int countRow = 0;
            for (int row = 0; row < matrixRow; row++)
            {
                nextNumber = 0;
                for (int col = 0; col < matrixCol; col++)
                {
                    if (count < arrayNumbers.Count)
                    {
                        matrix[row, col] = arrayNumbers[count];
                        count++;
                    }
                    else
                    {
                        if (col >= 4)
                        {
                            nextNumber = matrix[row, col - 4] + matrix[row, col - 3] + matrix[row, col - 2] + matrix[row, col - 1];
                        }
                        else
                        {
                            counCol = 0;
                            countRow = 0;
                            int currCol = col;
                            while (counCol < 4)
                            {
                                while (currCol <= 0)
                                {
                                    row--;
                                    currCol = matrixCol;
                                    countRow++;
                                }

                                nextNumber += matrix[row, currCol - 1];
                                currCol--;
                                counCol++;
                            }
                        }

                        while (countRow > 0)
                        {
                            row++;
                            countRow--;
                        }

                        matrix[row, col] = nextNumber;
                        nextNumber = 0;
                    }
                }
            }


            // print
            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < matrixCol; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                                
                Console.WriteLine();
            }
        }
    }
}
