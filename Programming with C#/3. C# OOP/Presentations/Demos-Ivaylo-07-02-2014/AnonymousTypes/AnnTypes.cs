namespace AnonymousTypes
{
    using System;
    using System.Collections.Generic;

    public class AnnyTypes
    {
        public static void Main()
        {
            var point = new
            {
                X = 10,
                Y = 100,
                Coordinates = new List<int> { 100, 200 },
                Name = "Pesho"
            };

            var anotherPoint = new
            {
                X = 100,
                Y = 200,
            };

            Console.WriteLine(point.X);

            var list = point.Coordinates;

            list.Add(500);

            foreach (var number in list)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(point.Name);

            int number200 = 200;

            var collection = new[]
            {
                4, 6, 10, number200
            };

            foreach (var number in collection)
            {
                Console.WriteLine(number);
            }

            var collectionOfObjects = new[]
            {
                new List<string> { "Pesho" },
                new List<string> { "Gosho" },
                new List<string> { "Gosho" },
                new List<string> { "Gosho" },
                new List<string> { "Gosho" },
                new List<string> { "Gosho" },
                new List<string> { "Gosho" }
            };

            var collectionOfAnnTypes = new[]
            {
                new { X = 10, Y = 20 },
                new { X = 100, Y = 200 }
            };

            foreach (var obj in collectionOfAnnTypes)
            {
                Console.WriteLine(obj.X + " " + obj.Y);
            }

            string someLine = "a b c";

            var separatedLine = someLine.Split(new[] { ' ', ',', '!' });
        }
    }
}
