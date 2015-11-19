namespace SourceControlSys.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class SourceControlSysDbContext : IdentityDbContext<User>, ISourceControlSysDbContext
    {
        public SourceControlSysDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Commit> Commits { get; set; }

        public virtual IDbSet<SoftwareProject> SoftwerProjects { get; set; }

        public static SourceControlSysDbContext Create()
        {
            return new SourceControlSysDbContext();
        }
    }
}
