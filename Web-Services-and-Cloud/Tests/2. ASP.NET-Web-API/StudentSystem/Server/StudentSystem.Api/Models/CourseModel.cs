namespace StudentSystem.Api.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using StudentSystem.Models;

    public class CourseModel
    {
        public static Expression<Func<Course, CourseModel>> FromCourse
        {
            get
            {
                return course => new CourseModel
                {
                    CourseId = course.Id,
                    Name = course.Name
                };
            }
        }

        [Key]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}