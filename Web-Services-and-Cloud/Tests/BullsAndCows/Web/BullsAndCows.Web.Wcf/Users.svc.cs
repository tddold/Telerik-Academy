namespace BullsAndCows.Web.Wcf
{
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class Users : BaseService, IUsers
    {
        public IEnumerable<ListedUserModel> GetAll(string page)
        {
            var pageAsNumber = int.Parse(page);

            return this.Users
                 .All()
                 .OrderBy(u => u.Email)
                 .Skip(pageAsNumber * 10)
                 .Take(10)
                .Select(u => new ListedUserModel
                {
                    Id = u.Id,
                    Username = u.Email
                })
                .ToList();
        }
    }
}
