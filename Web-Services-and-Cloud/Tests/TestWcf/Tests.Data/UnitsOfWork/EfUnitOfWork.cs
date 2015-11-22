namespace Tests.Data.UnitsOfWork
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using Tests.Data.Repositories;

    public class EfUnitOfWork : IUnitOfWork
    {
        private IDictionary<string, object> repos;
        public EfUnitOfWork(DbContext dbContext)
        {
            this.DbContext = dbContext;
            this.repos = new Dictionary<string, object>();
        }

        public DbContext DbContext { get; private set; }

        public IRepository<T> Get<T>() where T : class
        {
            var key = typeof(T).FullName;
            if (!this.repos.ContainsKey(key))
            {
                // грешно трябва с Ninject!!!
                var repo = new EfGenericRepository<T>(this.DbContext);

                this.repos.Add(key, repo);
            }

            return (IRepository<T>)this.repos[key];
        }

        public int SaveChanges()
        {
            return this.DbContext.SaveChanges();
        }
    }
}
