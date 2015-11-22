namespace Tests.Api
{
    using System.Linq;
    using System.ServiceModel.Web;
    using Data;
    using Tests.Models;
    using Data.UnitsOfWork;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Net;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QuestionsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select QuestionsService.svc or QuestionsService.svc.cs at the Solution Explorer and start debugging.
    public class QuestionsService : IQuestionsService
    {
        private EfUnitOfWork data;

        public QuestionsService()
        {
            var dbContext = new TestsDbContext();
            this.data = new EfUnitOfWork(dbContext);
        }
        public QuestionResponseModel AddQuestion(QuestionRequestModel model)
        {
            this.SetCorectContentType();

            // validation
            if (!this.IsModelValid(model))
            {
                throw new WebFaultException(HttpStatusCode.BadRequest);
            }
            var question = new Question();

            question.Text = model.Text;
            question.Category = this.loadOrCreateCategory(model.Category);
            question.DifficultyLevel = (DifficultyLevel)Enum.Parse(typeof(DifficultyLevel), model.Difficulty);
            question.Answers = this.GetAnswersFrom(model);

            this.data.Get<Question>()
                .Add(question);

            this.data.SaveChanges();

            WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Created;

            return QuestionResponseModel.FromQuestion
                .Compile()
                .Invoke(question);
        }

        public IQueryable<QuestionResponseModel> GetAll()
        {
            this.SetCorectContentType();

            return this.data.Get<Question>()
                .All()
                .Select(QuestionResponseModel.FromQuestion)
                .AsQueryable();
        }

        public IQueryable<QuestionResponseModel> GetQuestionsForCategory(string category)
        {
            category = category.ToLower();
            return this.GetAll()
                .Where(question => question.Category.ToLower() == category);
        }

        public QuestionResponseModel GetById(string id)
        {
            // validation for id
            this.SetCorectContentType();

            var question = this.data.Get<Question>()
                .GetById(int.Parse(id));

            return QuestionResponseModel.FromQuestion
                .Compile()
                .Invoke(question);
        }

        private bool IsModelValid(QuestionRequestModel model)
        {
            if (model == null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(model.Category))
            {
                return false;
            }

            if (string.IsNullOrEmpty(model.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(model.Difficulty))
            {
                return false;
            }

            if (model.CorrectAnswers == null || model.CorrectAnswers.Count() < 1)
            {
                return false;
            }

            if (model.WrongAnswers == null || model.WrongAnswers.Count() < 1)
            {
                return false;
            }

            return true;
        }

        private ICollection<Answer> GetAnswersFrom(QuestionRequestModel model)
        {
            var answers = new List<Answer>();
            model.CorrectAnswers
                .Select(text => new Answer(text, true))
                .ForEach(answers.Add);

            model.WrongAnswers
               .Select(text => new Answer(text))
               .ForEach(answers.Add);

            return answers;
        }

        private Category loadOrCreateCategory(string categoryName)
        {
            var category = this.data.Get<Category>()
                .All()
                .FirstOrDefault(
                    cat => cat.Name.ToLower() == categoryName.ToLower());

            if (category == null)
            {
                category = new Category()
                {
                    Name = categoryName
                };
            }

            return category;
        }

        private void SetCorectContentType()
        {
            var operationCtx = WebOperationContext.Current;
            var responseFormat = WebMessageFormat.Json;
            if (!string.IsNullOrEmpty(operationCtx.IncomingRequest.ContentType) &&
                operationCtx.IncomingRequest.ContentType.EndsWith("/xml"))
            {
                responseFormat = WebMessageFormat.Xml;
            }

            operationCtx.OutgoingResponse.Format = responseFormat;
        }
    }
}

