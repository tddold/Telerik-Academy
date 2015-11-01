namespace SourceControlSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class SoftwareProject
    {
        private ICollection<Commit> commits;
        private ICollection<User> users;

        public SoftwareProject()
        {
            this.users = new HashSet<User>();
            this.commits = new HashSet<User>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public bool Private { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }

        public virtual ICollection<Commit> Commits
        {
            get { return this.commits; }
            set { this.commits = value; }
        }

    }
}
