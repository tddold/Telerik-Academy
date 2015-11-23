namespace ExamTest.Web.Wcf
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using Models;

    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        [WebInvoke(Method = "Get", UriTemplate = "services/users.svc")]
        IEnumerable<ListedUserModel> GetAll(string page);
    }
}
