namespace Tests.Data.UnitsOfWork
{
    using Tests.Data.Repositories;

    public interface IUnitOfWork
    {
        IRepository<T> Get<T>()
            where T : class;

        int SaveChanges();
    }
}
