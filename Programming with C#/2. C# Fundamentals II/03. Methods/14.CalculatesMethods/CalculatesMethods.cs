/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculatesMethods
{
    public static int GetMin(params int[] number)
    {
        int min = number[0];

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] < min)
            {
                min = number[i];
            }
        }

        return min;
    }

    public static int GetMax(params int[] number)
    {
        int max = number[0];

        for (int i = 0; i < number.Length; i++)
        {
            if (max < number[i])
            {
                max = number[i];
            }
        }

        return max;
    }

    public static int GetAverange(params int[] number)
    {
        return GetSum(number) / number.Length;
    }

    public static int GetSum(params int[] number)
    {
        int sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            sum += number[i];
        }

        return sum;
    }

    public static int GetProduct(params int[] number)
    {
        int product = 1;

        for (int i = 0; i < number.Length; i++)
        {
            product *= number[i];
        }

        return product;
    }

    public static void Main()
    {
        string choice = "0";

        while (choice == "0")
        {
            Console.WriteLine("Program options for this set of number (1,2,3,4,5,6,7,8,9)");
            Console.WriteLine("     1) Calculate minimum of given set of integer numbers: ");
            Console.WriteLine("     2) Calculate maximum of given set of integer numbers: ");
            Console.WriteLine("     3) Calculate average of given set of integer numbers: ");
            Console.WriteLine("     4) Calculate sum of given set of integer numbers: ");
            Console.WriteLine("     5) Calculate product  of given set of integer numbers: ");
            Console.Write("\nEnter your choice:");
            choice = Console.ReadLine();
            Console.WriteLine("\n{0}", new string('-', 40));

            switch (choice)
            {
                case "1": Console.WriteLine("The Minimum of set integers: {0}", GetMin(1, 2, 3, 4, 5, 6, 7, 8, 9)); return;
                case "2": Console.WriteLine("The Maximum of set integers: {0}", GetMax(1, 2, 3, 4, 5, 6, 7, 8, 9)); return;
                case "3": Console.WriteLine("The Average Sum of set integers: {0}", GetAverange(1, 2, 3, 4, 5, 6, 7, 8, 9)); return;
                case "4": Console.WriteLine("The Sum of set integers: {0}", GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9)); return;
                case "5": Console.WriteLine("The Product of set integers: {0}", GetProduct(1, 2, 3, 4, 5, 6, 7, 8, 9)); return;
                default: Console.Clear(); choice = "0"; break;
            }
        }
    }
}