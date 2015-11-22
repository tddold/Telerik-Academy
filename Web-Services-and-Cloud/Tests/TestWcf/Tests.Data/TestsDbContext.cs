namespace Tests.Data
{
    using System.Data.Entity;
    using Tests.Models;

    public class TestsDbContext : DbContext
    {
        public TestsDbContext()
            : base("DefaultConnection")
        {
        }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Question> Questions { get; set; }

        public IDbSet<Answer> Answers { get; set; }
    }
}
