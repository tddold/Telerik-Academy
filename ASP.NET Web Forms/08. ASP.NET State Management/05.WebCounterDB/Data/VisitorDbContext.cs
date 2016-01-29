namespace _05.WebCounterDB.Data
{
    using System.Data.Entity;
    using Migrations;

    public class VisitorDbContext:DbContext
    {
        public VisitorDbContext()
            :base("VisitorConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<VisitorDbContext, Configuration>());
        }

        public IDbSet<Visitor> Visitors { get; set; }
    }
}