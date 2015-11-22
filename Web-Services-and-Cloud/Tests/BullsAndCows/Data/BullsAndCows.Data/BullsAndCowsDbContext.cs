namespace BullsAndCows.Data
{
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class BullsAndCowsDbContext : IdentityDbContext<User>, IBullsAndCowsDbContext
    {
        public BullsAndCowsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static BullsAndCowsDbContext Create()
        {
            return new BullsAndCowsDbContext();
        }
    }
}
