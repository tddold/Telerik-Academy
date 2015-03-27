namespace School_classes.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface ICommentable
    {
        List<string> Comments { get; set; }

        void AddComment(string comment);
    }
}
