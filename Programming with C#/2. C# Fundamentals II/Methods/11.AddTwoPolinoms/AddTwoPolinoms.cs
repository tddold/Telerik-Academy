using System;

/*Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5  -> [5, 0, 1]
*/

class AddTwoPolinoms
{
    static int[] AddPolinom(int firstPolinomExp, int secondPolinomExp)
    {
        int[] firstPolinom = new int[firstPolinomExp];
        int[] secondPolinom = new int[secondPolinomExp];

        Console.WriteLine("First Array : ");

        for (int i = 0; i < firstPolinom.Length; i++)
        {
            Console.Write("{0} coeficient = ", i);
            firstPolinom[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Second Array : ");

        for (int i = 0; i < secondPolinom.Length; i++)
        {
            Console.Write("{0} coeficient = ", i);
            secondPolinom[i] = int.Parse(Console.ReadLine());
        }

        int[] addedPolinom;
        if (firstPolinomExp > secondPolinomExp)
        {
            int i;
            addedPolinom = new int[firstPolinom.Length];
            for (i = 0; i < secondPolinom.Length; i++)
            {
                addedPolinom[i] = firstPolinom[i] + secondPolinom[i];
            }

            for (int j = i; j < firstPolinom.Length; j++)
            {
                addedPolinom[j] = firstPolinom[j];
            }
        }
        else
        {
            int i;
            addedPolinom = new int[secondPolinom.Length];
            for (i = 0; i < firstPolinom.Length; i++)
            {
                addedPolinom[i] = firstPolinom[i] + secondPolinom[i];
            }

            for (int j = i; j < secondPolinom.Length; j++)
            {
                addedPolinom[j] = secondPolinom[j];
            }

        }
        return addedPolinom;
    }

    static string PrintResult(int[] addedPolinom)
    {
        string result = "";

        for (int i = addedPolinom.Length - 1; i >= 0; i--)
        {
            if (i > 1)
            {
                result += addedPolinom[i].ToString() + "x^" + i + " " + "+" + " ";
            }
            else if (i == 1)
            {
                result += addedPolinom[i].ToString() + "x" + " " + "+" + " ";
            }
            else
            {
                result += addedPolinom[i].ToString();
            }
        }

        return result;
    }

    static void Main()
    {
        int firstPolinomEx = 2;
        int secondPolinomExp = 3;

        Console.WriteLine(PrintResult(AddPolinom(firstPolinomEx, secondPolinomExp)));
    }
}