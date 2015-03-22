/* Problem 2. IEnumerable extensions
 *  Implement a set of extension methods for IEnumerable<T> that implement the following group 
 *  functions: sum, product, min, max, average.*/

namespace IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    class TestIEnumerable
    {
        static void Main()
        {
            Console.WriteLine("Test: IEnumerable extensions methods");
            PrinSeparateLine();

            var source = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine("\nThe sum is {0} = {1}", string.Join(" + ", source), source.Sum());
            PrinSeparateLine();

            Console.WriteLine("\nThe product is {0} = {1}", string.Join(" * ", source), source.Product());
            PrinSeparateLine();

            Console.WriteLine("\nThe min element is: {0}", source.Min());
            PrinSeparateLine();

            Console.WriteLine("\nThe max element is: {0}", source.Max());
            PrinSeparateLine();

            Console.WriteLine("\nThe average of sequence {0} is: {1}", string.Join(", ", source), source.Average());
            PrinSeparateLine();
        }

        public static void PrinSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
