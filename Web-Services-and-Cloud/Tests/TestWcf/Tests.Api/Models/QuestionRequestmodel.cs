namespace Tests.Api.Models
{
    using System.Collections.Generic;

    public class QuestionRequestModel
    {
        public string Text { get; set; }

        public string Category { get; set; }

        public string Difficulty { get; set; }

        public IEnumerable<string> WrongAnswers { get; set; }

        public IEnumerable<string> CorrectAnswers { get; set; }
    }
}