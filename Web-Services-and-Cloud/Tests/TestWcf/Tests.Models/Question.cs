﻿namespace Tests.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        public DifficultyLevel DifficultyLevel { get; set; }
    }
}
