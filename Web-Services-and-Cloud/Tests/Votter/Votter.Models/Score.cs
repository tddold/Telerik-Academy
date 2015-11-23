namespace Votter.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Score
    {
        public int Id { get; set; }

        public int Points { get; set; }

        public int PictureId { get; set; }

        public virtual Picture Picture { get; set; }
    }
}
