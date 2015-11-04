namespace StudentSystem.Data
{
    using System.Data.Entity;
    using Common;
    using Contracts;
    using Migrations;
    using Models;

    public class StudentSystemDbContext : DbContext, IStudentSystemDbContext, IDbContext
    {
        public StudentSystemDbContext()
            : base(ConnectionStrings.StudentSystemConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
        }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Test> Tests { get; set; }

        public IDbSet<Material> Materials { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
