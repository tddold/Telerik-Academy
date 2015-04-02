using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy.Models
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            :base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Town name cannot be null!");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Town name cannot be empty or white space!");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());

            sb.AppendFormat("; Town={0}", this.Town);

            return sb.ToString();
        }
    }
}
