namespace School.Models
{
    using System;
    using System.Collections.Generic;
    using School.Interfaces;

    public class Person : ICommentable
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name is empty.");
                }

                this.name = value;
            }
        }

        public List<string> Comments { get; set; }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public override string ToString()
        {
            return string.Format("{0}", name);
        }
    }
}
