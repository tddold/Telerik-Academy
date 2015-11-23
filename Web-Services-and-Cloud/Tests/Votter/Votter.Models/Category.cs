namespace Votter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class Category
    {
        private ICollection<Picture> pictures;

        public Category()
        {
            this.pictures = new HashSet<Picture>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Picture> Pictures
        {
            get
            {
                return this.pictures;
            }
            set
            {
                this.pictures = value;
            }
        }
    }
}