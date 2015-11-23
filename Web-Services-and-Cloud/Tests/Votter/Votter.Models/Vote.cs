namespace Votter.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class Vote
    {
        [Key]
        public int VoteId { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual Picture UpVotePicture { get; set; }

        public virtual Picture DownVotePicture { get; set; }
    }
}