namespace Tests.Api
{
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using Models;
    using Tests.Models;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQuestionsService" in both code and config file together.
    [ServiceContract]
    public interface IQuestionsService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            UriTemplate = "/questions",
            ResponseFormat = WebMessageFormat.Json)]
        IQueryable<QuestionResponseModel> GetAll();

        [OperationContract]
        [WebInvoke(Method = "GET",
                    UriTemplate = "/questions?category={category}",
                    ResponseFormat = WebMessageFormat.Json)]
        IQueryable<QuestionResponseModel> GetQuestionsForCategory(string category);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/questions{id}")]
        QuestionResponseModel GetById(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/questions")]
        QuestionResponseModel AddQuestion(QuestionRequestModel question);
    }
}
