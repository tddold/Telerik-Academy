namespace PetStore.Services
{
    using PetStore.Data;
    using PetStore.Data.Migrations;
    using System.Data.Entity;


    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PetStoreDbContext, Configuration>());
        }
    }
}