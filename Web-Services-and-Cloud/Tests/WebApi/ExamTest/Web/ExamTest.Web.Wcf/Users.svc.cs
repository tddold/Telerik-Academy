namespace ExamTest.Web.Wcf
{
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using Models;

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Users : BaseService, IUsers
    {
        IEnumerable<ListedUserModel> IUsers.GetAll(string page)
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
