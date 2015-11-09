namespace _02.FindProductInRange
{
    /*
    2.Write a program to read a large collection of products (name + price) and efficiently find 
    the first 20 products in the price range [a…b].
    Test for 500 000 products and 10 000 price searches.
    Hint: you may use OrderedBag<T> and sub-ranges.
        */

    using System;
    using System.Diagnostics;

    public class Solve
    {
        private const int NumberOfProductsToAdd = 500000;
        private const int NumberOfSearches = 100000;
        private static readonly Random Rnd = new Random();
        private static readonly Stopwatch Sw = new Stopwatch();

        public static void Main()
        {
            var store = new Store();

            Console.Write("Please waite...");

            Sw.Start();
            AddProducts(store);
            Sw.Stop();

            Console.WriteLine();
            Console.WriteLine("\rCount: {0} | Elapsed time: {1}", store.Products.Count, Sw.Elapsed);

            Console.Write("Please waite...");

            Sw.Reset();
            SearchInPriceRange(store);
            Sw.Stop();

            Console.WriteLine("\nElapsed time: {0}\n", Sw.Elapsed);
        }

        private static void SearchInPriceRange(Store store)
        {
            for (int i = 0; i < NumberOfSearches; i++)
            {
                if (i % 1000 == 0)
                {
                    Console.Write(".");
                }

                int min = Rnd.Next(200);
                int max = Rnd.Next(400, 1000);

                store.SearchInPriceRange(min, max);
            }
        }

        private static void AddProducts(Store store)
        {
            for (int i = 0; i < NumberOfProductsToAdd; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.Write(".");
                }

                string name = Rnd.Next(int.MaxValue).ToString();
                decimal price = Rnd.Next(20000) / 100;
                store.AddProduct(new Product(name, price));
            }
        }
    }
}
