namespace SourceControlSystem.Api
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SourseControlSystemDbContext, Configuration>());
            SourseControlSystemDbContext.Create().Database.Initialize(true);
        }
    }
}