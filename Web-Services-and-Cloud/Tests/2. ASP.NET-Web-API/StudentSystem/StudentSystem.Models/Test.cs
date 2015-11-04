namespace StudentSystem.Models
{
    using System.Collections.Generic;

    public class Test
    {
        private ICollection<Student> students;

        public Test()
        {
            this.students = new HashSet<Student>();
        }

        public int Id { get; set; }

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public virtual int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
