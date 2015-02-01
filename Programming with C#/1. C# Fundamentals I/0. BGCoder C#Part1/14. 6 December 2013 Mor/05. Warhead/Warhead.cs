using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Warhead
{
    class Warhead
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);

            int[,] matrix = new int[16, 16];

            for (int row = 0; row < 16; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < 16; col++)
                {
                    matrix[row, col] = input[col] -'0';
                }
            }

            // print matrix
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < 16; row++)
            {
                for (int col = 0; col < 16; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
