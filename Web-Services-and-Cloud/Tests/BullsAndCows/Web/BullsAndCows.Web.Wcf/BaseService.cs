namespace BullsAndCows.Web.Wcf
{
    using Data;
    using BullsAndCows.Data.Repositories;

    public abstract class BaseService
    {
        public BaseService()
        {
            var db = new BullsAndCowsDbContext();
            this.Users = new GenericRepository<Users>(db);
        }

        protected IRepository<Users> Users { get; private set; }
    }
}