namespace School_classes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using School_classes.Interfaces;

    public class Commenter : ICommentable
    {
        public List<string> Comments
        {
            get
            {
                return this.Comments;
            }

            set
            {
                this.Comments = value;
            }
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
