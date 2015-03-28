/*Problem 2. Students and workers
 * Define abstract class Human with a first name and a last name. Define a new class Student which is 
 * derived from Human and has a new field – grade. Define class Worker derived from Human with a new 
 * property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per 
 * hour by the worker. Define the proper constructors and properties for this hierarchy.
 * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() 
 * extension method).
 * Initialize a list of 10 workers and sort them by money per hour in descending order.
 * Merge the lists and sort them by first name and last name.*/

namespace Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StudentsАndWorkersMain
    {
        public static void Main()
        {
            Console.WriteLine("Students and Workers");
            PrintSeparateLine();

            List<Student> students = new List<Student>
            {
                new Student("Asen", "Aseov", 5),
                new Student("Asen", "Ivanov", 4),
                new Student("Bobi", "Todorov", 3),
                new Student("Pesho", "Petrov", 2),
                new Student("Slavi", "Slavov", 5),
                new Student("Rosen", "Petrov", 6),
                new Student("Kalin", "Vasilev", 6),
                new Student("Radi", "Radev", 4),
                new Student("Luka", "Lukov", 3),
                new Student("Momchil", "Stoianov", 5)
            };

            // using lambda and the ToList method to sort the students
            students = students
                .OrderBy(x => x.Grade)
                .ToList();

            Console.WriteLine("> Students:\n ");

            foreach (var student in students)
            {
                Console.WriteLine("Grade: {0} | Full name: {1} {2}", student.Grade, student.FirstName, student.LastName);
            }

            List<Worker> workers = new List<Worker>
            {
                new Worker("Rumen", "Trifonov", 100, 8),
                new Worker("Angel", "Dobrev", 300, 8),
                new Worker("Pesho", "Peshev", 500, 8),
                new Worker("Suzi", "Petrov", 200, 4),
                new Worker("Moni", "Monev", 500, 8),
                new Worker("Ivan", "Vankov", 400, 6),
                new Worker("Nikola", "Nikolov", 300, 8),
                new Worker("Kolio", "Kolev", 200, 3),
                new Worker("Hari", "Harev", 100, 6),
                new Worker("Stoian", "Stoianov", 600, 8)
            };

            // using lambda and the ToList method to sort the workers
            workers = workers
                .OrderByDescending(x => x.MoneyPerHour()).ToList();

            Console.WriteLine("\n\n> Workers:\n");

            foreach (var worker in workers)
            {
                Console.WriteLine("Money per hour: {0, 5:F2} | Full name: {1} {2}", worker.MoneyPerHour(), worker.FirstName, worker.LastName);
            }

            // Merge lists
            var workersAndStudents = students.Concat<Human>(workers).ToList();

            // using lambda and the ToList method to sort the workers and the students
            workersAndStudents = workersAndStudents
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            Console.WriteLine("\n\n> Workers and Students:\n");

            foreach (var human in workersAndStudents)
            {
                Console.WriteLine("Full name: {0, -7} {1}", human.FirstName, human.LastName);
            }

            PrintSeparateLine();
        }

        private static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
