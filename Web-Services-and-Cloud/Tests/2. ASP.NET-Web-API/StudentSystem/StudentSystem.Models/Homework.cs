namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        private ICollection<Material> materials;

        public Homework()
        {
            this.materials = new HashSet<Material>();
        }

        public int Id { get; set; }
        
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public virtual ICollection<Material> Materials
        {
            get
            {
                return this.materials;
            }

            set
            {
                this.materials = value;
            }
        }

        [ForeignKey("Student")]
        public int StudentIdentification { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
