/** Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculatesMethodsGenericTypes
{
    public static T GetMin<T>(params T[] numbers) // where T : IComparable<T>
    {
        dynamic min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        return min;
    }

    public static T GetMax<T>(params T[] numbers) // where T : IComparable<T>
    {
        dynamic max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    public static T GetSum<T>(params T[] numbers) // where T : IComparable<T>
    {
        dynamic sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    public static T GetAverange<T>(params T[] numbers) // where T : IComparable<T>
    {
        dynamic averang = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            averang += numbers[i];
        }

        return averang / numbers.Length;
    }

    public static T GetProduct<T>(params T[] numbers) // where T : IComparable<T>
    {
        dynamic product = 1;
        for (int i = 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }

        return product;
    }

    public static void Main()
    {
        Console.WriteLine("The Minimum of set integers: {0}", GetMin(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Maximum of set integers: {0}", GetMax(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Average Sum of set integers: {0}", GetAverange(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Sum of set integers: {0}", GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9));
        Console.WriteLine("The Product of set integers: {0}", GetProduct(1, 2, 3, 4, 5, 6, 7, 8, 9));
    }
}