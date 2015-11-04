namespace StudentSystem.Data.Contracts
{
    using System.Data.Entity;
    using StudentSystem.Models;

    public interface IStudentSystemDbContext : IDbContext
    {
        IDbSet<Student> Students { get; }

        IDbSet<Course> Courses { get; }

        IDbSet<Homework> Homeworks { get; }

        IDbSet<Material> Materials { get; }

        IDbSet<Test> Tests { get; }
    }
}
