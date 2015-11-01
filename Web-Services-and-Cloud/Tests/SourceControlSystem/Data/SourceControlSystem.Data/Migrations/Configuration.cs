namespace SourceControlSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<SourseControlSystemDbContext>
    {
        public Configuration()
        {
           this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SourseControlSystemDbContext context)
        {           
        }
    }
}
