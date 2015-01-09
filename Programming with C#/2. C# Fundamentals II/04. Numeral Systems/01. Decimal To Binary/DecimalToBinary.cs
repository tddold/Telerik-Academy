// Write a program to convert decimal numbers to their binary representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinary
{
    public static string GetBinary(int number)
    {
        StringBuilder binaryNum = new StringBuilder();

        bool negativ = number < 0;

        if (negativ)
        {
            number = ~number;
        }

        while (number > 0)
        {
            binaryNum.Append(number%2);
            number /= 2;
        }

        if (negativ)
        {
            InverseBits(binaryNum);
        }

        Reverse(binaryNum);

        return binaryNum.ToString();
    }

    public static void InverseBits(StringBuilder binaryNum)
    {
        binaryNum.Append(new string('0', 32 - binaryNum.Length));

        for (int i = 0; i < binaryNum.Length; i++)
        {
            binaryNum[i] = (binaryNum[i] == '0') ? '1' : '0';
        }
    }

    public static void Reverse(StringBuilder binaryNum)
    {
        for (int i = 0; i < binaryNum.Length / 2; i++)
        {
            char tmp = binaryNum[i];
            binaryNum[i] = binaryNum[binaryNum.Length - 1 - i];
            binaryNum[binaryNum.Length - 1 - i] = tmp;
        }
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(GetBinary(number));
    }
}