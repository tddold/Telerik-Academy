namespace StudentSystem.Api.Models
{
    using StudentSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class TestModel
    {
        public static Expression<Func<Test, TestModel>> FromTest
        {
            get
            {
                return test => new TestModel
                {
                    CourseId = test.CourseId,
                    Students = test.Students,
                    TestId = test.Id

                };
            }
        }

        public int TestId { get; set; }

        public ICollection<Student> Students { get; set; }

        public int CourseId { get; set; }
    }
}