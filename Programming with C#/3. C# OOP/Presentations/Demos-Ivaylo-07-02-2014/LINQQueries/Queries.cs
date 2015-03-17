namespace LINQQueries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using IEnumerableNamespace;

    public class Queries
    {
        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static bool FirstName(Student student)
        {
            if (student.Name == "Boris")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            var oop = new Course { Id = 1, Name = "OOP" };
            var javaScript = new Course { Id = 2, Name = "JavaScript" };
            var cSharp = new Course { Id = 3, Name = "C#" };
            var html = new Course { Id = 4, Name = "HTML" };

            var students = new List<Student>
            {
                new Student 
                { 
                    Id = 1,
                    Name = "Zornitca",
                    DateOfBirth = new DateTime(1990, 12, 3),
                    Courses = new List<Course> {oop}
                },
                new Student
                {
                    Id = 2,
                    Name = "Albena",
                    DateOfBirth = new DateTime(1995, 1, 6),
                    Courses = new List<Course> { oop, javaScript, cSharp, html }
                },
                new Student
                {
                    Id = 3,
                    Name = "Pesho",
                    DateOfBirth = new DateTime(1950, 6, 20),
                    Courses = new List<Course> {  }
                },
                new Student
                {
                    Id = 4,
                    Name = "Boris",
                    DateOfBirth = new DateTime(1989, 4, 9),
                    Courses = new List<Course> { javaScript, html }
                },
                new Student
                {
                    Id = 5,
                    Name = "Unufri",
                    DateOfBirth = new DateTime(1978, 10, 15),
                    Courses = new List<Course> { javaScript, oop, cSharp }
                },
                new Student
                {
                    Id = 6,
                    Name = "Boris",
                    DateOfBirth = new DateTime(2000, 7, 17),
                    Courses = new List<Course> { javaScript, html, cSharp }
                },
            };

            // where first name starts with b
            var studentsWithFirstNameB = students.Where(st => st.Name.StartsWith("B"));
            // Print(studentsWithFirstNameB);

            // where id > 3 && courses >= 2
            var whereQueryCourserId = students.Where(st => st.Id > 3 && st.Courses.Count >= 2);
            // Print(whereQueryCourserId);

            // first found with some criteria
            Student firstWithNameBoris = students.FirstOrDefault(st => st.Name == "Boris43423");

            //if (firstWithNameBoris == null)
            //{
            //    Console.WriteLine("No such student!");
            //}
            //else
            //{
            //    Console.WriteLine(firstWithNameBoris);
            //}

            string studentName = "Boris";
            Student lastWithNameBoris = students.LastOrDefault(st => st.Name == studentName);
            // Console.WriteLine(lastWithNameBoris);

            // select to int
            var coursesCount = students.Select(st => st.Courses.Count);

            //foreach (var courseCount in coursesCount)
            //{
            //    Console.WriteLine(courseCount);
            //}

            // this is the same as above but more stupid
            List<int> coursesCountBalamskiMetod = new List<int>();

            foreach (var student in students)
            {
                coursesCountBalamskiMetod.Add(student.Courses.Count);
            }

            // select to class
            var selectToClass = students
                .Select(st =>
                    new ShortStudentInfo
                    {
                        Name = st.Name,
                        CoursesCount = st.Courses.Count,
                    });

            // select to ann type
            var onlyNamesAndCoursesCount = students
                .Where(st => st.Id > 2)
                .Select(st => new 
                    { 
                        Name = st.Name,
                        CourseCount = st.Courses.Count 
                    });

            //foreach (var stInfo in onlyNamesAndCoursesCount)
            //{
            //    Console.WriteLine(stInfo);
            
            // cast enum values
            var colors = Enum.GetValues(typeof(ColorEnum)).Cast<ColorEnum>().Select(c => c.ToString());

            //foreach (var color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            // order by students by year
            var sortedByYear = students.OrderBy(st => st.DateOfBirth.Year);
            //Print(sortedByYear);

            // order by more things
            var sortedByNameThenByYear =
                students
                .OrderBy(st => st.Name)
                .ThenBy(st => st.DateOfBirth.Year);

            // Print(sortedByNameThenByYear);

            // nested any
            bool someoneInJavaScript =
                students.Any(st => st.Courses.Any(c => c.Name == "JavaScript"));

            // Console.WriteLine(someoneInJavaScript);

            // anyone with Year >= 2000
            bool atLeast2000 =
                students.Any(st => st.DateOfBirth.Year >= 2000);

            // Console.WriteLine(atLeast2000);

            bool everyoneYoungerThan2000
                = students.All(st => st.DateOfBirth.Year >= 2000);

            // Console.WriteLine(everyoneYoungerThan2000);

            // cast to array
            var arrayOfStudents = students.ToArray();
            var listOfStudents = students.ToList();

            // reverse
            //students.Reverse();
            //Print(students);

            // student with max courses
            int maxStudent = students.Max(st => st.Courses.Count);
            // Console.WriteLine(maxStudent);

            int minStudentId = students.Min(st => st.Id);
            // Console.WriteLine(minStudentId);

            int sum = students.Sum(st => st.DateOfBirth.Year);
            // Console.WriteLine(sum);

            double average = students.Average(st => st.DateOfBirth.Year);
            // Console.WriteLine(average);

            double averageActive = students
                .Where(st => st.Courses.Count > 0)
                .Average(st => st.DateOfBirth.Year);

            // Console.WriteLine(averageActive);

            int countActive = students.Count(st => st.Courses.Count > 2);
            // Console.WriteLine(countActive);

            // var collectionOfStudents = students.Where("Age > 10 & Course.Count == 10");
            
            // fat query
            var someCollection =
                students
                .Where(st => st.Id > 2 || st.DateOfBirth.Year > 1990)
                .OrderBy(st => st.Name)
                .ThenBy(st => st.Courses.Count)
                .Select(st => new
                {
                    FirstNameSymbol = st.Name[0],
                    Year = st.DateOfBirth.Year,
                })
                .ToList();

            foreach (var student in someCollection)
            {
                Console.WriteLine(student);
            }
        }
    }
}
