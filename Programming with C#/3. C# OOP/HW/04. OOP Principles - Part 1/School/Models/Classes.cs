namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Classes : Person
    {
        private string textIdentifier;
        private List<Teachers> teachersForClass;

        public Classes(string name, string textIdentifire, params Teachers[] teachersForClass)
            : base(name)
        {
            this.TextIdentifire = textIdentifire;
            this.teachersForClass = new List<Teachers>();
            this.teachersForClass.AddRange(teachersForClass);
        }

        public string TextIdentifire
        {
            get
            {
                return this.textIdentifier;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("INvalid text identifire.");
                }

                this.textIdentifier = value;
            }
        }

        // public List<Teachers> TeachersForClass { get; set; }

        public override string ToString()
        {
            return string.Format("Classes : \n{0} - Teacher {1}", this.textIdentifier, string.Join("\n", this.teachersForClass));
        }
    }
}
