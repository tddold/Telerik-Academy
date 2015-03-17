namespace ALotOfFeatures
{
    using System;

    using ALotOfFeatures.Extensions;

    public class ExtensionsDemo
    {
        static void Main()
        {
            string pesho = "Pesho";
            string agrPesho = pesho.AggregateWith(10);
            Console.WriteLine(agrPesho);
            agrPesho = pesho.AggregateWith(10, ',');
            Console.WriteLine(agrPesho);
        }
    }
}
