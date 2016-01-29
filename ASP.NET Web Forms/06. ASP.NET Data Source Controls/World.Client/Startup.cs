namespace World.Client
{
    using System;
    using System.Linq;
    using World.Data;

    class Startup
    {
        static void Main()
        {
            WorldDbContext data = new WorldDbContext();
            data.Continents.Count();
            Console.WriteLine("World database created, now you can use database first aproach");
        }
    }
}
