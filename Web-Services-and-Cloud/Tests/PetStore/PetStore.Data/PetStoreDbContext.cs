namespace PetStore.Data
{
    using Models;
    using System.Data.Entity;

    public class PetStoreDbContext : DbContext
    {
        public PetStoreDbContext()
            : base("DefaultConection")
        {
        }

        public virtual IDbSet<Pet> Pets { get; set; }
    }
}
