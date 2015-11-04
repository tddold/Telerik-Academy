namespace StudentSystem.Api.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using StudentSystem.Models;

    public class StudentModel
    {
        public static Expression<Func<Student, StudentModel>> FromStudent
        {
            get
            {
                return student => new StudentModel
                {
                    StudentId = student.StudentId,
                    FirstName = student.FirstName,
                    LastName = student.LastName
                };
            }
        }

        [Key]
        public int StudentId { get; set; }

        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }
    }
}