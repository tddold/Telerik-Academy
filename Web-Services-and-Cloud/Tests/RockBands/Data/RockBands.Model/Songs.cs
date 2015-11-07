namespace RockBands.Model
{
    using RockBands.Model.Contracts;
    using System.ComponentModel.DataAnnotations;

    public class Songs : ISong
    {
        [Key]
        public int SongId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Link { get; set; }

        [Range(0, int.MaxValue)]
        public int Raiting { get; set; }

        [Required]
        public string Src { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
