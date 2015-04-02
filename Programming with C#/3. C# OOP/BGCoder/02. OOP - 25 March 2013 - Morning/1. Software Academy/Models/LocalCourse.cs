using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy.Models
{
    public class LocalCourse: Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            :base(name, teacher)
        {
            this.Lab = lab;
        }
        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Lab name cannot be null!");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Lab name cannot be empty or white space!");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());            

            sb.AppendFormat("; Lab={0}", this.Lab);

            return sb.ToString();
        }
    }
}
