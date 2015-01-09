using System;

/*Extend the program to support also subtraction and multiplication of polynomials.*/

class SubtractionAndMultiplicationOfPolinoms
{
    static int[] MultiplyPolinoms(int firstPolinomExp, int secondPolinomExp)
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
                addedPolinom[i] = firstPolinom[i] * secondPolinom[i];
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
                addedPolinom[i] = firstPolinom[i] * secondPolinom[i];
            }

            for (int j = i; j < secondPolinom.Length; j++)
            {
                addedPolinom[j] = secondPolinom[j];
            }

        }

        Console.Write("Multiplyed polinoms : ");
        return addedPolinom;
    }

    static int[] SubstractPolinoms(int firstPolinomExp, int secondPolinomExp)
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
                addedPolinom[i] = firstPolinom[i] - secondPolinom[i];
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
                addedPolinom[i] = firstPolinom[i] - secondPolinom[i];
            }

            for (int j = i; j < secondPolinom.Length; j++)
            {
                addedPolinom[j] = secondPolinom[j];
            }

        }

        Console.Write("Substracted polinoms : ");
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
        Console.Write("Enter exponent of the first polinom: ");
        int firstPolinomEx = int.Parse(Console.ReadLine());
        Console.Write("Enter exponent of the second polinom: ");
        int secondPolinomExp = int.Parse(Console.ReadLine());
        Console.Write("\nWhat do you want :\n\n1.Multiply 2 polinoms\n2.Substract 2 polinoms\n\nPress \"1\" or \"2\" : ");

        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine(PrintResult(MultiplyPolinoms(firstPolinomEx, secondPolinomExp)));
        }
        else if (choice ==2)
        {
            Console.WriteLine(PrintResult(SubstractPolinoms(firstPolinomEx, secondPolinomExp)));
        }
        else
        {
            Console.WriteLine("Whrong input !!!"); 
        }

        
    }
}