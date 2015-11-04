namespace StudentSystem.Data.Contracts
{
    using System;
    using StudentSystem.Models;

    public interface IStudentSystemData : IDisposable
    {
        IRepository<Course> Courses { get; }

        IRepository<Homework> Homeworks { get; }

        IRepository<Material> Materials { get; }

        IRepository<Student> Students { get; }

        IRepository<Test> Tests { get; }

        int SaveChanges();
    }
}
