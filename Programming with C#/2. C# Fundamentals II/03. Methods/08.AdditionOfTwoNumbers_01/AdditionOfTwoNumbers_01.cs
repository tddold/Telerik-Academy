using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AdditionOfTwoNumbers_01
{
    static string AddingDigits(string first, string second)
    {
        int[] firstArray = new int[first.Length];
        int[] secondArray = new int[second.Length];

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = first[i] - 48;
        }

        for (int i = 0; i < second.Length; i++)
        {
            secondArray[i] = second[i] - 48;
        }

        int max = firstArray.Length;

        if (max < secondArray.Length)
        {
            max = secondArray.Length;
        }

        int[] addedDigits = new int[max + 1];
        int counter1 = 1;
        int counter2 = 1;
        int minus1 = addedDigits.Length - 1;
        int minus2 = addedDigits.Length - 1;

        for (int i = addedDigits.Length-1; i >0; i--)
        {
            while (minus1 > firstArray.Length)
            {
                counter1++;
                minus1--;
            }

            while (minus2 > secondArray.Length)
            {
                counter2++;
                minus2--;
            }

            if (i - counter1 < 0)
            {
                addedDigits[i] += secondArray[i - counter2];
                if (addedDigits[i] > 9)
                {
                    addedDigits[i] -= 10;
                    addedDigits[i - 1] += 1;
                }
                continue;
            }

            if (i - counter2 < 0)
            {
                addedDigits[i] += firstArray[i - counter1];
                if (addedDigits[i] > 9)
                {
                    addedDigits[i] -= 10;
                    addedDigits[i - 1] += 1;
                }
                continue;
            }

            if (firstArray[i - counter1] + secondArray[i - counter2] > 9)
            {
                addedDigits[i] += (firstArray[i - counter1] + secondArray[i - counter2]) % 10;
                addedDigits[i - 1] += 1;
            }
            else
            {
                addedDigits[i] += firstArray[i - counter1] + secondArray[i - counter2];
            }

        }

        string result = string.Join("", addedDigits);

        if (result[0] == '0')
        {
            result = result.Remove(0, 1);
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter the first number :" + new string(' ', 6));
        string first = Console.ReadLine();
        Console.Write("Enter the second number:" + new string(' ', 6));
        string second = Console.ReadLine();
        Console.WriteLine(new string('-', 35));

        Console.WriteLine("Result is:{0,23}", AddingDigits(first, second));
    }
}