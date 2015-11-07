namespace RockBands.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }

        public int BandId { get; set; }

        public virtual Band Brand { get; set; }
    }
}
