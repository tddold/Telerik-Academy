/*Problem 4. Age range
 * Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/

namespace Age_range
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class TestAgeRange
    {
        static void Main()
        {
            Console.WriteLine("Test: The first name and last name of all students with age between 18 and 24.");
            PrintSeparateLine();

            var students = new[] 
            {
                new { FirstName = "Ivan", LastName = "Petrov" , Age = 15},
                new { FirstName = "Petar", LastName = "Ivanov", Age = 19},
                new { FirstName = "Gosho", LastName = "Goshev", Age = 25},
                new { FirstName = "Asen", LastName = "Georgiev", Age = 35},
                new { FirstName = "Ivan", LastName = "Asenov", Age = 20},
            };

            var linqQuery =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select new
                {
                    student.FirstName,
                    student.LastName
                };

            Console.WriteLine("#1: Using Linq query:");
            foreach (var student in linqQuery)
            {
                Console.WriteLine(student);
            }
            
            PrintSeparateLine();

                
               
                

        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
