namespace BullsAndCows.Web.Wcf
{
    using Models;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        [WebInvoke(Method = "Get", UriTemplate = "services/users.svc")]
        IEnumerable<ListedUserModel> GetAll(string page);
    }
}
