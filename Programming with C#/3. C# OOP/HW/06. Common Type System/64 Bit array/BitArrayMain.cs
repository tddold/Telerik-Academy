/*Problem 5. 64 Bit array
 * Define a class BitArray64 to hold 64 bit values inside an ulong value.
 * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.*/

namespace _64_Bit_array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BitArrayMain
    {
        public static void Main()
        {
            Console.WriteLine("Problem 5. 64 Bit array");
            PrintSeparateLine();

            var array = new List<ulong> { 1, 2, 3, 4, 5, 6 };
            var bitArray = new BitArray64(array);

            Console.WriteLine("Foreach BitArray64:");

            foreach (var arr in bitArray)
            {
                Console.Write(arr + ", ");
            }

            Console.WriteLine();

            var newArray = new List<ulong> { 1, 2, 3, 4, 5, 6, 7 };
            var newBitArray = new BitArray64(newArray);

            Console.WriteLine("\nCompareTo:");
            Console.WriteLine("Result: {0}", bitArray != newBitArray);
            PrintSeparateLine();
        }

        private static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
