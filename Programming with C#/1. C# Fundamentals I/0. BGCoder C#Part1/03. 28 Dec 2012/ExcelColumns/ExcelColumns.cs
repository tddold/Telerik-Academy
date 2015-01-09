using System;
using System.Collections.Generic;

class ExcelColumns
{
    const int index = 64;
    const int baseSystem = 26;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string input = String.Empty;
        for (int i = 0; i < n; i++)
        {
            input += Console.ReadLine();
        }

        List<int> columnIndex = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            columnIndex.Add(input[i] - index);
        }

        long result = 0;
        for (int i = 0; i < n; i++)
        {
            result += (long) columnIndex[n - 1 - i] * (long) Math.Pow(baseSystem, i);
        }

        Console.WriteLine(result);
    }
}