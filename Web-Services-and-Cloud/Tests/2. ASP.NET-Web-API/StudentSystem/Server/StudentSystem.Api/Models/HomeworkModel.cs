using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace StudentSystem.Api.Models
{
    public class HomeworkModel
    {
        public static Expression<Func<Homework, HomeworkModel>> FromHomework
        {
            get
            {
                return homework => new HomeworkModel
                {
                    HomeworkId = homework.Id,
                    Content = homework.Content,
                    CourseId = homework.CourseId,
                    StudentId = homework.StudentId,
                    TimeSent = homework.TimeSent
                };
            }
        }

        [Key]
        public int HomeworkId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public int CourseId { get; set; }

        public int? StudentId { get; set; }
    }
}