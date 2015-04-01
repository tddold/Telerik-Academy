namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;

    public interface IEditable
    {
        void ChangeContent(string newContent);
    }
}
