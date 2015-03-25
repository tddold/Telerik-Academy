namespace School.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface ICommentable
    {
        // the class should have a list of comments
        List<string> Comments { get; set; }

        // the class should have a method to add something to those comments
        void AddComment(string comment);
    }
}
