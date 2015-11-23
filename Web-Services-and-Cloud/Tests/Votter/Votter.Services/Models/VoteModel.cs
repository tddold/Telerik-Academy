namespace Votter.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class VoteModel
    {
        //[Required]
        //[MinLength(40)]
        //[MaxLength(40)]
        public string UserId { get; set; }

        public int UpVotePictureId { get; set; }

        public int DownVotePictureId { get; set; }
    }
}