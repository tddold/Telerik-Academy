namespace _12.Extract_Price_Albums_With_LING
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    internal class ExtractPriceAlbumsWithLINQ
    {        
        private static void Main()
        {
            var xmlDoc = XDocument.Load("../../catalogue.xml");

            var priceCatalogue =
                from album in xmlDoc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2005
                select new
                {
                    Name = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            foreach (var item in priceCatalogue)
            {
                Console.WriteLine("Album name: {0, -15} -> price: {1, 2}", item.Name, item.Price);
            }                
        }
    }
}
