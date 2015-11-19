namespace SourceControlSys.Api
{
    using System.Data.Entity;
    using SourceControlSys.Data;
    using SourceControlSys.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SourceControlSysDbContext, Configuration>());
            SourceControlSysDbContext.Create().Database.Initialize(true);
        }
    }
}