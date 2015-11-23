namespace  ExamTest.Web.Api
{
    using System.Data.Entity;
    using  ExamTest.Data;
    using Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Initilize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion< ExamTestDbContext, Configuration>());
            //  ExamTestDbContext.Create().Database.Initialize(true);
        }
    }
}