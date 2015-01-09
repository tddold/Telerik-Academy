using System;

class MissCat2011Array
{
    static void Main(string[] args)
    {
        int judge = int.Parse(Console.ReadLine());

        int[] cats = new int[11];

        for (int i = 0; i < judge; i++)
        {
            int mark = int.Parse(Console.ReadLine());

            cats[mark]++;
        }

        int max = 0;
        int result = 0;
        for (int i = 0; i < cats.Length; i++)
        {
            int currentValue = cats[i];

            if (currentValue > max)
            {
                max = currentValue;
                result = i;
            }
        }

        Console.WriteLine(result);
    }
}