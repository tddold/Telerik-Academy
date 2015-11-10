namespace DataStructuresEfficiency
{
    /*
    2. A large trade company has millions of articles, each described by barcode
    , vendor, title and price.
    Implement a data structure to store them that allows fast retrieval of all
    articles in given price range [x…y].
    Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET.
        */

    using System;
    using System.Diagnostics;

    public class TradeCompany
    {
        private const int numOfProductsToAdd = 500000;
        private const int numOfProductsToSearch = 5000000;

        private static readonly Random Rnd = new Random();
        private static readonly Stopwatch Sw = new Stopwatch();

        public static void Main()
        {
            var store = new Store();

            Console.Write("Please wait... ");

            Sw.Start();
            AddProducts(store);
            Sw.Stop();

            Console.WriteLine("\rAdding products -> Elapsed time: {0}", Sw.Elapsed);

            Sw.Start();
            SearchProductsInPriceRange(store);
            Sw.Stop();

            Console.WriteLine("\nSearching products -> Elapsed time: {0}\n", Sw.Elapsed);
        }

        private static void AddProducts(Store store)
        {
            for (int i = 0; i < numOfProductsToAdd; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.Write(".");
                }

                string name = Rnd.Next(int.MaxValue).ToString();
                decimal price = Rnd.Next(20000) / 100;

                store.AddProduct(new Product(name, price));
            }

            Console.WriteLine();
        }

        private static void SearchProductsInPriceRange(Store store)
        {
            for (int i = 0; i < numOfProductsToSearch; i++)
            {
                int min = Rnd.Next(200);
                int max = Rnd.Next(250, 2000);

                store.SearchInPriceRange(min, max);
            }
        }
    }
}
