/*
Task 1. Students and courses

Write three classes: Student, Course and School.
Students should have name and unique number (inside the entire School).
Name can not be empty and the unique number is between 10000 and 99999.
Each course contains a set of students.
Students in a course should be less than 30 and can join and leave courses.
Write VSTT tests
Use 2 class library projects in Visual Studio: School.csproj and School.Tests.csproj
Execute the tests using Visual Studio and check the code coverage. Ensure it is at least 90%.
*/

namespace School.Client
{
    using System;
    using System.Linq;
    using School.Models;

    internal class SchoolClient
    {
        private static void Main()
        {
            var school = new School();

            var studentPesho = school.RegisterStudent("Pesho");
            Console.WriteLine(studentPesho);

            var studentSimo = school.RegisterStudent("Simo");
            Console.WriteLine(studentSimo);

            var hqcCourse = school.RegisterCourse("High Quality Code");
            school.AddStudentToCourse(studentPesho, hqcCourse);
            school.AddStudentToCourse(studentSimo, hqcCourse);

            Console.WriteLine(hqcCourse);

        }
    }
}
