namespace Tests.Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Tests.Models;

    [DataContract]
    public class QuestionResponseModel
    {
        public static Expression<Func<Question, QuestionResponseModel>> FromQuestion
        {
            get
            {
                return q => new QuestionResponseModel()
                {
                    Text = q.Text,
                    Id = q.Id,
                    Category = q.Category.Name,
                    Answers = q.Answers
                                    .Select(ans => ans.Text)
                                    .ToList()
                };
            }
        }

        [DataMember]
        public IEnumerable<string> Answers { get; private set; }

        [DataMember]
        public string Category { get; private set; }

        [DataMember]
        public int Id { get; private set; }

        [DataMember]
        public string Text { get; private set; }
    }
}