namespace SourceControlSys.Models
{
    using SoureceControlSys.Common.Constants;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class SoftwareProject
    {
        private ICollection<Commit> commits;
        private ICollection<User> users;

        public SoftwareProject()
        {
            this.users = new HashSet<User>();
            this.commits = new HashSet<Commit>();
        }
        public int Id { get; set; }

        public bool Private { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxProjectName)]
        public string Name { get; set; }

        [MaxLength(ValidationConstants.MaxProjectDescription)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }

        public ICollection<Commit> Commits
        {
            get { return this.commits; }
            set { this.commits = value; }
        }
    }
}
