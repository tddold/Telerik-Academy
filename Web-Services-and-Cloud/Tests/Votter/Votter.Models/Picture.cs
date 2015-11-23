namespace Votter.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>
    /// Picture uploaded by given user for given category
    /// One user can upload one picture for one category
    /// </summary>
    public class Picture
    {
        [Key]
        public int PictureId { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string Link { get; set; }

        public int ScoreId { get; set; }

        public virtual Score Score { get; set; }
    }
}