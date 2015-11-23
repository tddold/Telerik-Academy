namespace ExamTest.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class ExamTestDbContext : IdentityDbContext<User>, IExamTestDbContext
    {
        public ExamTestDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ExamTestDbContext Create()
        {
            return new ExamTestDbContext();
        }
    }
}
