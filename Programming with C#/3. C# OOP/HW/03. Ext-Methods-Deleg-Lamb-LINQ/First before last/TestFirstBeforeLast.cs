/*Problem 3. First before last
 * Write a method that from a given array of students finds all students whose first name is before its last name 
 * alphabetically.
 * Use LINQ query operators.*/

namespace First_before_last
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TestFirstBeforeLast
    {
        public static void Main()
        {
            Console.WriteLine("Test: First before last.");
            PrintSeparateLine();

            var students = new[] 
            {
                new { FirstName = "Ivan", LastName = "Petrov" },
                new { FirstName = "Petar", LastName = "Ivanov" },
                new { FirstName = "Gosho", LastName = "Goshev" },
                new { FirstName = "Asen", LastName = "Georgiev" },
                new { FirstName = "Ivan", LastName = "Asenov" },
            };

            // Linq query
            var sortName =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            Console.WriteLine("#1: Using Linq Query:\n");
            Console.WriteLine(string.Join(Environment.NewLine, sortName));
            PrintSeparateLine();

            // Extendet method
            var extSortName = students
                .Where(x => x.FirstName
                    .CompareTo(x.LastName) < 0);

            Console.WriteLine("#2: Using Lambda expression\n");
            Console.WriteLine(string.Join(Environment.NewLine, extSortName));
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
