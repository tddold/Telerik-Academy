namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public Test()
        {
            this.Studemnts = new HashSet<Student>();
        }

        public int Id { get; set; }

        public ICollection<Student> Studemnts { get; private set; }

        public virtual Guid CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
