namespace SourceControlSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class SourseControlSystemDbContext : IdentityDbContext<User>, ISourseControlSystemDbContext
    {
        public SourseControlSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Commit> Commits { get; set; }

        public virtual IDbSet<SoftwareProject> SoftwareProjects { get; set; }

        public static SourseControlSystemDbContext Create()
        {
            return new SourseControlSystemDbContext();
        }
    }
}
