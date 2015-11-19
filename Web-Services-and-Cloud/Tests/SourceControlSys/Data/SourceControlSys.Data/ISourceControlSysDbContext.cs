namespace SourceControlSys.Data
{
    using System.Data.Entity;
    using SourceControlSys.Models;
    using System.Data.Entity.Infrastructure;

    public interface ISourceControlSysDbContext
    {
        IDbSet<Commit> Commits { get; set; }

        IDbSet<SoftwareProject> SoftwerProjects { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}