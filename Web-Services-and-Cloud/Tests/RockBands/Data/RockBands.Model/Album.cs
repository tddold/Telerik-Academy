namespace RockBands.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        public int Raiting { get; set; }

        public DateTime ReleasedAt { get; set; }

        [Required]
        public string Src { get; set; }

        public string ImageUrl { get; set; }

        public int BandId { get; set; }

        public virtual Band Band { get; set; }
    }
}
