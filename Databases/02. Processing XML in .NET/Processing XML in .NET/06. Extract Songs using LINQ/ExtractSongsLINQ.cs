namespace _06.Extract_Songs_using_LINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class ExtractSongsLINQ
    {
        static void Main()
        {
            string file = "../../catalogue.xml";

            XDocument xmlDoc = XDocument.Load(file);

            var songs = from song in xmlDoc.Descendants("song")
                        select new
                        {
                            Title = song.Element("title").Value,
                        };

            Console.WriteLine("Found {0} songs.", songs.Count());
            Console.WriteLine("\nSong title is:");

            int count = 0;
            foreach (var song in songs)
            {
                count++;
                Console.WriteLine("{0, 2}. {1}", count, song.Title);
            }
        }
    }
}
