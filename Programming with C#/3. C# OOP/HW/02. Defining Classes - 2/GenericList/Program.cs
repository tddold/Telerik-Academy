/*Problem 5. Generic class
 *  Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
 *  Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
 *  Implement methods for adding element, accessing element by index, removing element by index, inserting element at
 *  given position, clearing the list, finding element by its value and ToString().
 *  Check all input parameters to avoid accessing elements at invalid positions.
 *  
 * Problem 6. Auto-grow
 *  Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all 
 *  elements to it.
 *  
 * Problem 7. Min and Max
 *  Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
 *  You may need to add a generic constraints for the type T.*/

namespace GenericList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            GenericList<int> test = new GenericList<int>();

            Console.WriteLine("Test Generic class");
            PrintSeparateLine();
            PrintSeparateLine();

            // Empty list
            Console.WriteLine("Empty list");
            Console.WriteLine(test);
            Console.WriteLine("Count: {0}", test.Count);
            Console.WriteLine("Capacity: {0}", test.Capacity);
            PrintSeparateLine();

            // Add eloements
            Console.WriteLine("Add elements\n");

            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);

            Console.WriteLine(test);
            Console.WriteLine("Count: {0}", test.Count);
            Console.WriteLine("Capacity: {0}", test.Capacity);
            PrintSeparateLine();

           // Implement IEnumerable
            Console.WriteLine("Implement IEnumerable\n");

            foreach (var element in test)
            {
                Console.Write(element + ", ");
            }

            Console.WriteLine();
            PrintSeparateLine();

            // Clear 
            Console.WriteLine("Clear elements\n");

            test.Clear();

            Console.WriteLine("Count: {0}", test.Count);
            Console.WriteLine("Capacity: {0}", test.Capacity);

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

            PrintSeparateLine();

            // Insert
            Console.WriteLine("Insert element at position\n");

            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);

            Console.WriteLine(test);
            Console.WriteLine("Count: {0}", test.Count);
            Console.WriteLine("Capacity: {0}\n", test.Capacity);

            int value = 5;
            int index = 2;

            Console.WriteLine("Insert: {0} to index: {1}", value, index);

            test.InsertOf(value, index);

            Console.WriteLine("\n" + test);
            Console.WriteLine("Count: {0}", test.Count);
            Console.WriteLine("Capacity: {0}", test.Capacity);
            PrintSeparateLine();

            // Contains, IndexOf
            Console.WriteLine("Contains and IndexOf\n");

            int findElemrnt = 5;

            Console.WriteLine("arr[{0}] = {1}", test.IndexOf(findElemrnt), findElemrnt);
            Console.WriteLine("Cantain element {1} is in array - {0}", test.Contain(findElemrnt), findElemrnt);
            PrintSeparateLine();

            // RemoveAt
            Console.WriteLine("RemoveAt\n");
            Console.WriteLine(test);
            Console.WriteLine("Count: {0}", test.Count);
            Console.WriteLine("Capacity: {0}", test.Capacity);
            Console.WriteLine("\nRemove element in index: {0}", index);

            test.RemoveAt(index);

            Console.WriteLine(test);
            Console.WriteLine("Count: {0}", test.Count);
            Console.WriteLine("Capacity: {0}", test.Capacity);
            PrintSeparateLine();

            // Auto-grow functionality
            Console.WriteLine("Auto-grow functionality\n");

            test.Clear();

            for (int i = 0; i < 20; i++)
            {
                test.Add(i);
            }

            Console.Write("Print using ToString: ");

            Console.WriteLine(test);           

            Console.Write("Print using foreach:  ");

            foreach (var item in test)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Count: {0}", test.Count);
            Console.WriteLine("Capacity: {0}", test.Capacity);
            PrintSeparateLine();

            // Max, Min
            Console.WriteLine("Min ana Max");
            Console.WriteLine("\nMin: {0}", test.Min());
            Console.WriteLine("Max: {0}", test.Max());
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
