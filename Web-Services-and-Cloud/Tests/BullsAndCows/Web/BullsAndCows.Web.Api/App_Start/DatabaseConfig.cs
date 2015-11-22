namespace BullsAndCows.Web.Api
{
    using System.Data.Entity;
    using BullsAndCows.Data;
    using Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initilize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BullsAndCowsDbContext, Configuration>());
            // BullsAndCowsDbContext.Create().Database.Initialize(true);
        }
    }
}