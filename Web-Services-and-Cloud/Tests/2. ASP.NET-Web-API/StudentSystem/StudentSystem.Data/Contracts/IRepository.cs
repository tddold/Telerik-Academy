namespace StudentSystem.Data.Contracts
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> All();

        IQueryable<T> Search(Expression<Func<T, bool>> condition);

        T Find(int id);

        T GetById(object id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(object id);

        T Attach(T entity);

        void Detach(T entity);

        void SaveChanges();
    }
}
