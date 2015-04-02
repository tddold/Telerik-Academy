using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy.Models
{
    public class Teacher : ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Teacher name cannot be null!");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Teacher name cannot be empty or white space!");
                }

                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Teacher: Name={0}", this.Name);

            if (this.courses.Count > 0)
            {
                sb.AppendFormat("; Courses=[{0}]", string.Join(", ", this.courses.Select(x => x.Name)));
            }

            return sb.ToString();
        }
    }
}
