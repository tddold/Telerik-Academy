
/*Problem 5. Order students
 * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by
 * first name and last name in descending order.
 * Rewrite the same with LINQ.*/
namespace Order_students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class TestOrderStudents
    {
        static void Main()
        {
            Console.WriteLine("Test: Order students!");
            PrintSeparateLine();

            var students = new[]
            {
                 new { FirstName = "Ivan", LastName = "Petrov" },
                new { FirstName = "Petar", LastName = "Ivanov" },
                new { FirstName = "Gosho", LastName = "Goshev" },
                new { FirstName = "Asen", LastName = "Georgiev" },
                new { FirstName = "Ivan", LastName = "Asenov" },
            };

            // Methods OrderBy() and ThenBy() with lambda expressions
            var sortedOrderBy = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .Select(x => x)
                .ToList();

            Console.WriteLine("Methods OrderBy() and ThenBy() with lambda expressions.\n");
            Console.WriteLine(string.Join(Environment.NewLine, sortedOrderBy));
            PrintSeparateLine();

            // Methods with LINQ
            var sortedByLinq =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;


            Console.WriteLine("Methods with LINQ.\n");
            Console.WriteLine(string.Join(Environment.NewLine, sortedByLinq));
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
