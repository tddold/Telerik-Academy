namespace StudentSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using StudentSystem.Data.Contracts;
    using StudentSystem.Models;
    using Repositories;

    public class StudentSystemData : IStudentSystemData
    {
        private readonly DbContext context;
        private readonly IDictionary<Type, object> repositories = new Dictionary<Type, object>();

        public StudentSystemData()
            : this(new StudentSystemDbContext())
        {
        }

        public StudentSystemData(DbContext context)
        {
            this.context = context;
        }

        public IRepository<Course> Courses
        {
            get
            {
                return this.GetRepository<Course>();
            }
        }

        public IRepository<Homework> Homeworks
        {
            get
            {
                return this.GetRepository<Homework>();
            }
        }

        public IRepository<Material> Materials
        {
            get
            {
                return this.GetRepository<Material>();
            }
        }

        public IRepository<Student> Students
        {
            get
            {
                return this.GetRepository<Student>();
            }
        }

        public IRepository<Test> Tests
        {
            get
            {
                return this.GetRepository<Test>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);

            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var typeOfRepository = typeof(EFGenericRepository<T>);
                this.repositories.Add(typeOfModel, Activator.CreateInstance(typeOfRepository, this.context));
            }

            return (IRepository<T>)this.repositories[typeOfModel];
        }
    }
}
