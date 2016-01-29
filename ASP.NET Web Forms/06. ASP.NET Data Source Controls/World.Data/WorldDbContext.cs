namespace World.Data
{
    using System.Data.Entity;
    using World.Models;
    using World.Data.Migrations;


    public class WorldDbContext: DbContext
    {
        public WorldDbContext()
            : base("World")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WorldDbContext, Configuration>());
        }

        public virtual IDbSet<Continent> Continents { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<Country> Countries { get; set; }
    }
}
