namespace RockBands.Model
{
    using RockBands.Model.Contracts;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Band : ISong
    {
        private ICollection<Album> albums;
        private ICollection<Artist> artists;

        public Band()
        {
            this.albums = new HashSet<Album>();
            this.artists = new HashSet<Artist>();
        }

        [Key]
        public int BandId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string OfficialSite { get; set; }

        [Range(0, int.MaxValue)]
        public int Raiting { get; set; }

        public DateTime ReleasedAt { get; set; }

        [Required]
        public string Src { get; set; }

        public virtual ICollection<Album> Albums
        {
            get
            {
                return this.albums;
            }

            set
            {
                this.albums = value;
            }
        }

        public virtual ICollection<Artist> Artists
        {
            get
            {
                return this.artists;
            }

            set
            {
                this.artists = value;
            }
        }
    }
}
