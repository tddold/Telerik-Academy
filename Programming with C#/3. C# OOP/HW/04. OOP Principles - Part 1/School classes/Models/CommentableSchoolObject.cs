namespace School_classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CommentableSchoolObject: Commenter
    {
        private string name;

        public CommentableSchoolObject()
        {

        }

        public CommentableSchoolObject(string name)
        {
            this.Name= name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name is empty.");
                }

                this.name = value;
            }
        }
    }
}
