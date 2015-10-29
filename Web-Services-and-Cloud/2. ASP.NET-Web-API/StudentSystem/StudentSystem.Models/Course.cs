namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CourseIntance")]
    public class Course
    {
        public Course()
        {
            this.Id = Guid.NewGuid();
            this.Student = new HashSet<Student>();
            this.Homeworks = new HashSet<Homework>();
        }

        public Guid Id { get; private set; }

        [Column("CourseName")]
        public string Name { get; set; }

        public virtual ICollection<Student> Student { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}
