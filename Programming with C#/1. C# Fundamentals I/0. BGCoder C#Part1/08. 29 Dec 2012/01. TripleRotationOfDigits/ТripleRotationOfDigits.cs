using System;
using System.Text;

class ТripleRotationOfDigits
{
    static void Main()
    {
        // input
        StringBuilder inputNumber = new StringBuilder(Console.ReadLine());


        for (int i = 0; i < 3; i++)
        {
            if (inputNumber[inputNumber.Length - 1] == '0')
            {
                inputNumber.Remove(inputNumber.Length - 1, 1);
            }
            else
            {
                string moveNumber = inputNumber[inputNumber.Length - 1].ToString();
                inputNumber.Remove(inputNumber.Length - 1, 1);
                inputNumber.Insert(0, moveNumber);
            }
        }

        // print
        Console.WriteLine(inputNumber);
    }
}