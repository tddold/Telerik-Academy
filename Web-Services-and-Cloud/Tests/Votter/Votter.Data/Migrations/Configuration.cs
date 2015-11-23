namespace Votter.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Votter.Data.Contracts;
    using Votter.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            this.SeedCategories(context);
        }

        private void SeedCategories(IVotterDbContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }

            context.Categories.Add(new Category()
            {
                Name = "Men"
            });

            context.Categories.Add(new Category()
            {
                Name = "Women"
            });

            context.Categories.Add(new Category()
            {
                Name = "Trainers"
            });

            context.Categories.Add(new Category()
            {
                Name = "Cars"
            });

            context.Categories.Add(new Category()
            {
                Name = "Animals"
            });

            context.SaveChanges();
        }
    }
}