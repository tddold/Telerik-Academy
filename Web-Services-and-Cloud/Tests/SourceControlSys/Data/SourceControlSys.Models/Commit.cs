﻿namespace SourceControlSys.Models
{
    using System;

    public class Commit
    {
        public int Id { get; set; }

        public string SourceCode { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int SoftwerProjectId { get; set; }

        public virtual SoftwareProject SoftwerProject { get; set; }
    }
}
