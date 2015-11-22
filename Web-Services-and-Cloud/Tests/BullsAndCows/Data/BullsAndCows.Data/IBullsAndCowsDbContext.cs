namespace BullsAndCows.Data
{
    using Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface IBullsAndCowsDbContext
    {
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        IDbSet<User> Users { get; set; }

        void Dispose();

        int SaveChanges();
    }
}
