using System;
using System.Linq;

class FindMaximalElement
{
    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("The matrix is:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write(" ");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    static void PrintSumNumber(int[,] matrix)
    {
        // int count = matrix.GetLength(1);
        int count = 0;
        if (matrix.GetLength(0) > matrix.GetLength(1))
        {
            count = matrix.GetLength(0);
        }
        else
        {
            count = matrix.GetLength(1);
        }

        Console.WriteLine("The sum number is:");
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--, count--)
        {
            Console.Write(new string(' ', count));
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    static int[,] AddTwoDiggits(string a, string b)
    {
        int[] first = new int[a.Length];
        int[] second = new int[b.Length];
        int[,] matrix = new int[second.Length, first.Length + 1];

        for (int i = 0; i < first.Length; i++)
        {
            first[i] = a[i] - 48;
        }

        for (int i = 0; i < second.Length; i++)
        {
            second[i] = b[i] - 48;
        }

        for (int row = second.Length - 1; row >= 0; row--)
        {
            for (int col = first.Length; col > 0; col--)
            {
                if ((second[row] * first[col - 1]) < 10)
                {
                    matrix[row, col] += second[row] * first[col - 1];
                }
                else
                {
                    matrix[row, col] += (second[row] * first[col - 1]) % 10;
                    matrix[row, col - 1] = (second[row] * first[col - 1]) / 10;
                }
            }
        }

        return matrix;
    }

    static string GetResult(string a, string b)
    {
        int[,] matrix = AddTwoDiggits(a, b);
        int count1 = a.Length;
        int count2 = 1;
        int[] resultArray = new int[a.Length + b.Length + 1];

        for (int row = b.Length - 1; row >= 0; row--, count1--, count2++)
        {
            int count = resultArray.Length - count2;

            for (int col = a.Length + count1; col >= count1; col--, count--)
            {
                if (resultArray[count] + matrix[row, col - count1] < 10)
                {
                    resultArray[count] += matrix[row, col - count1];
                }
                else
                {
                    resultArray[count] += matrix[row, col - count1];
                    resultArray[count] %= 10;
                    resultArray[count - 1]++;
                }
            }
        }

        string result = string.Join("", resultArray);
        while (result[0] == '0')
        {
            result = result.Remove(0, 1);
        }

        return result;
    }

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        string a = "123";
        string b = "456";
       
        // Print
        Console.WriteLine("Numbers is:{0} * {1}", a, b);
        PrintMatrix(AddTwoDiggits(a, b));
        PrintSumNumber(AddTwoDiggits(a, b));
        Console.WriteLine(new string('-', 16));
        Console.WriteLine(GetResult(a, b));
    }
}