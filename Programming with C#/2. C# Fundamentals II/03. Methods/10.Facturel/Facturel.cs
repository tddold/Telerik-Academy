using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.*/

class Facturel
{
    static int[,] MultiplyNumbers(string a, string b)
    {
        int[] first = new int[a.Length];
        int[] second = new int[b.Length];

        int[,] matrix = new int[second.Length, first.Length + 1];

        for (int i = 0; i < first.Length; i++)
        {
            first[i] = a[i] - 48;
        }

        for (int i = 0; i < b.Length; i++)
        {
            second[i] = b[i] - 48;
        }

        for (int row = second.Length - 1; row >= 0; row--)
        {
            for (int col = first.Length; col > 0; col--)
            {
                if (second[row] * first[col - 1] < 10)
                {
                    matrix[row, col] += second[row] * first[col - 1];
                }
                else
                {
                    matrix[row, col] += (second[row] * first[col - 1]) % 10;
                    matrix[row, col - 1] += second[row] * first[col - 1] / 10;
                }
            }
        }

        return matrix;
    }

    static string GetResult(string a, string b)
    {
        int[,] matrix = MultiplyNumbers(a, b);
        int coun1 = a.Length;
        int coun2 = 1;
        int[] arr = new int[a.Length + b.Length + 1];

        for (int row = b.Length - 1; row >= 0; row--, coun1--, coun2++)
        {
            int count = arr.Length - coun2;

            for (int col = a.Length + coun1; col >= coun1; col--, count--)
            {
                if (count >= 0)
                {
                    if (arr[count] + matrix[row, col - coun1] < 10)
                    {
                        arr[count] += matrix[row, col - coun1];
                    }
                    else
                    {
                        arr[count] += matrix[row, col - coun1];
                        arr[count] %= 10;
                        arr[count - 1]++;
                    }

                    if (coun1 < 0)
                    {
                        coun1 = 0;
                    }
                }
                else
                {
                    if (arr[count] + matrix[row, col - coun1] < 10)
                    {
                        arr[count] += matrix[row, col - coun1];
                    }
                    else
                    {
                        arr[count] += matrix[row, col - coun1] % 10;
                        arr[count] %= 10;
                        arr[count - 1]++;
                    }
                }
            }
        }

        string result = string.Join("", arr);

        while (result[0] == '0')
        {
            result = result.Remove(0, 1);
        }

        return result;
    }

    static void PrintResult(string result)
    {
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }

        Console.WriteLine("\n");
    }

    static void Main()
    {
        string number1 = "1237";
        string number2 = "456";

        string result = GetResult(number1, number2);
        PrintResult(result);
    }
}