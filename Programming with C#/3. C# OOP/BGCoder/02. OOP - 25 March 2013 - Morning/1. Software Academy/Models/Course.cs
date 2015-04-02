using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy.Models
{
    public abstract class Course : ICourse
    {
        private string name;
        private ICollection<string> topics;

        protected Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new LinkedList<string>();
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
                    throw new ArgumentNullException("Course name cannot be null!");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course name cannot be empty or white space!");
                }

                this.name = value;
            }
        }

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0}: Name={1}", this.GetType().Name, this.Name);

            if (this.Teacher != null)
            {
                sb.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }

            if (this.topics.Count > 0)
            {
                sb.AppendFormat("; Topics=[{0}]", string.Join(", ", this.topics));
            }


            return sb.ToString();
        }
    }
}
