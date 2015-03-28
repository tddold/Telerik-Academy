/*Problem 1. School classes
 * We are given a school. In the school there are classes of students. Each class has a set of 
 * teachers. Each teacher teaches, a set of disciplines. Students have a name and unique class number.
 * Classes have unique text identifier. Teachers have a name. Disciplines have a name, number of 
 * lectures and number of exercises. Both teachers and students are people. Students, classes, 
 * teachers and disciplines could have optional comments (free text block).
 * Your task is to identify the classes (in terms of OOP) and their attributes and operations, 
 * encapsulate their fields, define the class hierarchy and create a class diagram with Visual 
 * Studio.*/

namespace School_classes
{
    using School_classes.Interfaces;
    using School_classes.Models;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SchoolMain
    {
        static void Main()
        {
            Console.WriteLine("School");
            PrintSeparateLine();

            var school = new School(new Classes("10b", Guid.NewGuid().ToString()),
                                    new Classes("10a", Guid.NewGuid().ToString()),
                                    new Classes("11b", Guid.NewGuid().ToString()));

            List<Students> students = new List<Students>
            {
                new Students("Pepo", 12),
                new Students("Gosho", 13),
                new Students("Ivo", 14),
                new Students("Hari", 15),


            };

            Console.WriteLine("\n> Students:\n");

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0, -5} | ID: {1}", student.Name, student.UniqueClassNumber);
            }

            List<Teachers> teachers = new List<Teachers>
            {
                new Teachers("Ivan Ivanoiv", new Disciplines("Biologic", 5, 5)),
                new Teachers("Pesho Pesev", new Disciplines("Mathematic", 15, 15)),
                new Teachers("Asen Asenv", new Disciplines("History", 5, 5)),
            };

            Console.WriteLine("\n\n> Teachers:\n");
            
            foreach (var teacher in teachers)
            {
                Console.WriteLine("Name: Mr.{0, -12} | Discipline: {1}", teacher.Name, string.Join(", ", teacher.Discipline));
            }

            Console.WriteLine("\n\n> Classes:\n");
            Console.WriteLine(string.Join(Environment.NewLine, school.Classes));

            PrintSeparateLine();
           
        }

        private static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
