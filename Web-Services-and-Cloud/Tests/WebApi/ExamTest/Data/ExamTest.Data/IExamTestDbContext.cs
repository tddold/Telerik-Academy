namespace ExamTest.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Models;

    public interface IExamTestDbContext
    {
        IDbSet<User> Users { get; set; }

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
