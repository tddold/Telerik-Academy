namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Material
    {
        [Key]
        public int MaterialId { get; set; }

        [Required]
        public string DownloadUrl { get; set; }

        public virtual MaterialType Type { get; set; }

        [ForeignKey("Homework")]
        public int HomeworkId { get; set; }

        public virtual Homework Homework { get; set; }
    }
}
