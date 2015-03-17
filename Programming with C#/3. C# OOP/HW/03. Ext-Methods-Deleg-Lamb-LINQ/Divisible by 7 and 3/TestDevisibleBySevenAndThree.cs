/*Problem 6. Divisible by 7 and 3
 * Write a program that prints from given array of integers all numbers that
 * are divisible by 7 and 3. Use the built-in extension methods and lambda expressions.
 * Rewrite the same with LINQ.*/

namespace Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TestDevisibleBySevenAndThree
    {
        public static void Main()
        {
            Console.WriteLine("Divisible by 7 and 3");
            PrintSeparateLine();


            Console.WriteLine("\nGiven array:");

            var array = new int[50];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Console.WriteLine(string.Join(", ", array));

            // Method with Lambda expression
            var devisibleByLmbda = array
                .Where(x => (x % 3) == 0 && (x % 7) == 0)
                .Select(x => x)
                .ToArray();

            Console.WriteLine("\nMethod with Lambda expression");
            Console.WriteLine(string.Join(", ", devisibleByLmbda));

            // Method with Linq
            var devisibleByLinq =
                from num in array
                where num % 3 == 0 && num % 7 == 0
                select num;

            Console.WriteLine("\nMethod with LINQ.");
            Console.WriteLine(string.Join(", ", devisibleByLinq));
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
