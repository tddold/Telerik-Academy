namespace IEnumerableNamespace
{
    using System;
    using System.Collections.Generic;

    public class IEnumerableTest
    {
        public static void AddNumber(int number)
        {
            Console.WriteLine(number + 100);
        }

        public static void Main()
        {
            List<int> enumerable = new List<int>() { 5 , 10, 100 };

            Console.WriteLine("Using slow way");
            foreach (var item in enumerable)
            {
                // do something
                Console.WriteLine(item);
            }

            Console.WriteLine("Using cool way");
            enumerable.ForEach(Console.WriteLine);

            enumerable.ForEach(AddNumber);

            enumerable.ForEach(x => Console.WriteLine(x + 10000));
        }
    }
}
