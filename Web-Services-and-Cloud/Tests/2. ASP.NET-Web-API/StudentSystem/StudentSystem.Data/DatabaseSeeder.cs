namespace StudentSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentSystem.Data.Contracts;
    using StudentSystem.Models;

    public class DatabaseSeeder
    {
        private readonly IStudentSystemData studentSystemData;

        public DatabaseSeeder(IStudentSystemData studentSystemData)
        {
            this.studentSystemData = studentSystemData;
        }

        public void SeedDataToDatabase()
        {
            this.SeedCourses();
            this.SeedStudents();
            this.AddHomeworksToSpecificStudent();
        }

        private void SeedCourses()
        {
            if (this.studentSystemData.Courses.All().Count() != 0)
            {
                return;
            }

            this.studentSystemData.Courses.Add(new Course()
            {
                Name = "C# Part 1",
                Homeworks = new List<Homework>() { new Homework() { Content = "Introduction to Programming with C-Sharp", Materials = new List<Material>() { new Material() { Type = MaterialType.Presentation, DownloadUrl = @"http://telerikacademy.com/" }, new Material() { Type = MaterialType.SourceCode, DownloadUrl = @"http://telerikacademy.com/" } } } }
            });

            this.studentSystemData.Courses.Add(new Course()
            {
                Name = "C# Part 2",
                Homeworks = new List<Homework>() { new Homework() { Content = "Arrays", Materials = new List<Material>() { new Material() { Type = MaterialType.Presentation, DownloadUrl = @"http://telerikacademy.com/" } } } }
            });

            this.studentSystemData.Courses.Add(new Course()
            {
                Name = "C# OOP"
            });

            this.studentSystemData.Courses.Add(new Course()
            {
                Name = "PHP Web-Development"
            });

            this.studentSystemData.Courses.Add(new Course()
            {
                Name = "HTML5 / CSS3 Fundamentals"
            });

            this.studentSystemData.SaveChanges();
        }

        private void SeedStudents()
        {
            if (this.studentSystemData.Students.All().Count() != 0)
            {
                return;
            }

            this.studentSystemData.Students.Add(new Student()
            {
                FirstName = "John",
                LastName = "Snow",
                Courses = this.studentSystemData.Courses.All().Take(2).ToList()
            });

            this.studentSystemData.Students.Add(new Student()
            {
                FirstName = "Pesho",
                LastName = "Peshev"
            });

            this.studentSystemData.SaveChanges();
        }

        private void AddHomeworksToSpecificStudent()
        {
            if (this.studentSystemData.Homeworks.All().Count() != 0)
            {
                return;
            }

            var firstStudent = this.studentSystemData.Students.All().First();
            var someHomework = this.studentSystemData.Courses.All().First().Homeworks.First();

            firstStudent.Homeworks.Add(new Homework()
            {
                Content = someHomework.Content,
                Course = someHomework.Course,
                TimeSent = DateTime.Now
            });

            this.studentSystemData.SaveChanges();
        }
    }
}
