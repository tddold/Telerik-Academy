using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Binary_Digits_Count
{
    [System.Runtime.InteropServices.GuidAttribute("43D49AAA-6441-4CC6-8117-803735388836")]
    class BinaryDigitsCount
    {
        static void Main()
        {
            //if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
            //{
            //    Console.SetIn(new StreamReader("input.txt"));
            //}

            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            long[,] matrix = new long[n, 64];

            for (int i = 0; i < n; i++)
            {
                long inputNumbers = long.Parse(Console.ReadLine());
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (inputNumbers >> j) & 1;
                }
            }

            // solution
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int couunt = 0;
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sb.Append(matrix[row, col]);
                }

                string str = sb.ToString();
                str = str.TrimEnd("0".ToCharArray());

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == b + 48)  //може и по този начин --> char.Parse(b.ToString()))
                    {
                        couunt++;
                    }
                }

                Console.WriteLine(couunt);
            }

            // print
            // PrinMatrix(matrix);

        }

        private static void PrinMatrix(long[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
