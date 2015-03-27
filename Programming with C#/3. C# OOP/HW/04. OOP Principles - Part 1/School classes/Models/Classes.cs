namespace School_classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Classes : SchoolObject
    {
        private string uniqueTextIdentifier;
        private List<Teachers> teachers;

        public Classes(string name, string uniqueTextIdentifier, params Teachers[] teacher)
            :base(name)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.Teachers = new List<Teachers>(teacher);
            this.Teachers.AddRange(teacher);
        }

        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("INvalid text identifire.");
                }

                this.uniqueTextIdentifier = value;
            }
        }

        public List<Teachers> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                this.teachers = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Class: {0}, UniqueTI: {1} - {2}", base.Name, this.uniqueTextIdentifier, this.Name);
        }
    }
}
