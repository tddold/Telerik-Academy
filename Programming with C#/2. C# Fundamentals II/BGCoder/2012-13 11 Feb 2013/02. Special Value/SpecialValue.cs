using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Special_Value
{
    class SpecialValue
    {
        static int[][] ReadDate(int[][] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                int[] currLine = input
                    .Split(new char[]{',', ' '},StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                field[i] = new int[currLine.Length];

                for (int j = 0; j < currLine.Length; j++)
                {
                    field[i][j] = currLine[j];
                }
            }           

            return field;
        }

        static long FindCurrentSpeshalValue(int[][] field , int column, bool[][] used)
        {
            long result = 0;
            int currRow = 0;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                used[i] = new bool[field[i].Length];
            }

            while (true)
            {
                result++;

                if (used[currRow][column])
                {
                    return long.MinValue;
                }

                if (field[currRow][column] < 0)
                {
                    result -= field[currRow][column];
                    return result;
                }

                int nextColumn = field[currRow][column];
                used[currRow][column] = true;
                column = nextColumn;

                currRow++;

                if (currRow == field.GetLength(0))
                {
                    currRow = 0;
                }
            }

            return result;
        }

        static void Main()
        {            
            // read input
            int N = int.Parse(Console.ReadLine());

            int[][] field = new int[N][];

            bool[][] used = new bool[N][];

            field = ReadDate(field);

            for (int i = 0; i < field.GetLength(0); i++)
            {
                used[i] = new bool[field[i].Length];
            }

            long max = long.MinValue;

            for (int i = 0; i < field[0].Length; i++)
            {
                long spacialValue = FindCurrentSpeshalValue(field, i, used);

                if (max < spacialValue)
                {
                    max = spacialValue;
                }
            }

            Console.WriteLine(max);
        }
    }
}
