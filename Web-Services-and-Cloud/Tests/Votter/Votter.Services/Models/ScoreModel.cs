using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Votter.Services.Models
{
    public class ScoreModel
    {

        public int PictureId { get; set; }
        public string ApplicationUserId { get; set; }
        public int Score { get; set; }

    }
}