namespace School_classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person : CommentableSchoolObject
    {
        public Person(string name)
            : base(name)
        {

        }

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}
