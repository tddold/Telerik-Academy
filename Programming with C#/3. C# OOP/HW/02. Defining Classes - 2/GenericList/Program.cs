namespace GenericList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            GenericList<int> test = new GenericList<int>();

            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);

            Console.WriteLine(test.Count);
            Console.WriteLine(test);

            foreach (var element in test)
            {
                Console.WriteLine(element);
            }

            test.Clear();
            Console.WriteLine(test.Count);
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            Console.WriteLine(test);

            // Insert
            test.InsertOf(5, 2);
            Console.WriteLine(test);

            // Contains, IndexOf
            int findElemrnt = 5;
            Console.WriteLine("arr[{0}] = {1}", test.IndexOf(findElemrnt), findElemrnt);
            Console.WriteLine("element {1} is in array - {0}", test.Contain(findElemrnt), findElemrnt);


            // RemoveAt
            Console.WriteLine(test.Count);
            test.RemoveAt(2);
            Console.WriteLine(test);
            Console.WriteLine(test.Count);

            // Auto-grow functionality
            test.Clear();
            for (int i = 0; i < 20; i++)
            {
                test.Add(i);
            }

            Console.WriteLine(test);
            Console.WriteLine(test.Count);

            foreach (var item in test)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            // Max, Min
            Console.WriteLine("\nMin: {0}", test.Min());
            Console.WriteLine("Max: {0}", test.Max());
        }
    }
}
