namespace SourceControlSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class SourseControlSystemDbContext : IdentityDbContext<User>
    {
        public SourseControlSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static SourseControlSystemDbContext Create()
        {
            return new SourseControlSystemDbContext();
        }
    }
}
