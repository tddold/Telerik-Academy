namespace Votter.Services.Models
{
    using System;
    using System.Linq;

    public class PictureModel
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        public string Link { get; set; }

        public int CategoryId { get; set; }
    }
}