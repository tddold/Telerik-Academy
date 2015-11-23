namespace ExamTest.Web.Wcf
{
    using Data;
    using Data.Models;
    using ExamTest.Data.Repositories;

    public abstract class BaseService
    {
        protected BaseService()
        {
            var db = new ExamTestDbContext();
            this.Users = new EfGenericRepository<User>(db);
        }

        protected IRepository<User> Users { get; private set; }
    }
}