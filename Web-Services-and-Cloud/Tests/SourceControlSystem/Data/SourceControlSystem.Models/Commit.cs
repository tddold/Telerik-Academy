namespace SourceControlSystem.Models
{
    using System;

    public class Commit
    {
        public int Id { get; set; }

        public string SourseCode { get; set; }

        public DateTime CreateOn { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int SoftwareProjectId { get; set; }

        public SoftwareProject SoftwareProject { get; set; }

    }
}
