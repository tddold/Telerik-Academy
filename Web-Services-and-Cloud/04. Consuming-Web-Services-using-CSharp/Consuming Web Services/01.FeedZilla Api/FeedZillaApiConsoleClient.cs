namespace FeedZillaApi
{
    using System;
    using FeedZillaApi.Models;

    public class FeedZillaApiConsoleClient
    {
        private static readonly FeedZillaConsumer feedZillaConsumer = new FeedZillaConsumer();
        private static readonly Action<Article> articleAction =
            (a) => Console.WriteLine("Title: {0}\nUrl: {1}\n", a.Title, a.Url);

        internal static void Main()
        {
            Console.Write("Enter a search pattern (for example: 'bulgaria'): ");
            string searchPattern = Console.ReadLine();

            Console.Write("Number of articles to take: ");
            int articlesCount = int.Parse(Console.ReadLine());

            Console.WriteLine("\nArticles");
            feedZillaConsumer.GetArticles(searchPattern, articlesCount, articleAction);
        }
    }
}
