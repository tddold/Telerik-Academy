using System;

class Asrodlogical
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        int sum = 0;


        while (true)
        {
            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (!(inputNumber[i] == '.' || inputNumber[i] == '-'))
                {
                    sum += int.Parse(inputNumber[i].ToString());
                }
            }

            if (sum < 10)
            {
                break;
            }

            inputNumber = sum.ToString();
            sum = 0;
        }

        Console.WriteLine(sum);
    }
}