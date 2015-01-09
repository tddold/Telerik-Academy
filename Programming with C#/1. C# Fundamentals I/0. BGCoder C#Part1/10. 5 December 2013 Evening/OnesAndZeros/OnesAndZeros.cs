using System;
using System.Linq;
using System.Text;
class OnesAndZeros
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string binaryNumber = Convert.ToString(n, 2).PadLeft(16, '0');
        StringBuilder number = new StringBuilder();

        char dot = '.';
        char dies = '#';

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[i] == '0')
            {
                number.Append('!').Append(binaryNumber[i]).Append('!').Append('.');
            }
            else if (binaryNumber[i] == '1')
            {
                number.Append('-').Append(binaryNumber[i]).Append('_').Append('.');
            }
        }
        
        number.Remove(number.Length - 1, 1);
        
        while (true)
        {
            if (number.Length == 63)
            {
                break;
            }

            number.Remove(0, 1);
        }

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < number.Length; col++)
            {
                if (row == 0 && number[col] == '0')
                {
                    Console.Write(dies);
                }
                else if (row == 0 && (number[col] == '-' || number[col] == '_'))
                {
                    Console.Write(dot);
                }
                else if (row == 1 && number[col] == '-')
                {
                    Console.Write(dies);
                }
                else if (row == 4 && (number[col] == '-' || number[col] == '_' || number[col] == '0'))
                {
                    Console.Write(dies);
                }
                else if (number[col] == '!' || number[col] == '1')
                {
                    Console.Write(dies);
                }
                else if (number[col] == '0' || number[col] == '.' || number[col] == '-' || number[col] == '_')
                {
                    Console.Write(dot);
                }
            }

            Console.WriteLine();
        }
    }
}