namespace LINQQueries
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            return this.Id + " " + this.Name + " " + this.DateOfBirth.Year +
                "." + this.DateOfBirth.Month + "." + this.DateOfBirth.Date +
                " " + this.Courses.Count;
        }
    }
}
