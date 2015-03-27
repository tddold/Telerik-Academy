namespace School_classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class School
    {
        private List<Classes> classes;

        public School()
        {

        }

        public School(params Classes[] classes)
        {
            this.Classes = new List<Classes>();
            this.Classes.AddRange(classes);
        }

        public List<Classes> Classes
        {
            get
            {
                return this.classes;
            }

            private set
            {
                this.classes = value;
            }
        }

        public void AddClasses(Classes newClasses)
        {
            this.classes.Add(newClasses);
        }

        public void RemoveClasses(Classes removeClasses)
        {
            this.classes.Remove(removeClasses);
        }

        public override string ToString()
        {
            return string.Format("Class: {0}", this.Classes);
        }
    }
}
