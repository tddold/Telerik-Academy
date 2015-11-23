namespace Votter.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Votter.Common;
    using Votter.Data.Contracts;
    using Votter.Data.Migrations;
    using Votter.Models;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IVotterDbContext
    {
        public ApplicationDbContext()
            : base(ConnectionStrings.DefaultConnection, throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Picture> Pictures { get; set; }

        public IDbSet<Vote> Votes { get; set; }

        public IDbSet<Score> Score { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}