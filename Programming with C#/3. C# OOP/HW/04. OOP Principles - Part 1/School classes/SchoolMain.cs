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
            var school = new School(new Classes("10b", Guid.NewGuid().ToString()),
                                    new Classes("10a", Guid.NewGuid().ToString()),
                                    new Classes("11b", Guid.NewGuid().ToString()));

            var teachers = new Teachers("Ivan Ivanov", new Disciplines("History", 10, 5));
            var discipline = new Disciplines("Matemathic", 15, 15);


            

            Students student = new Students("Ivan Ivanov", 1);
            Teachers teacher1 = new Teachers("Pesho Peshev", new Disciplines("Mathematic", 1, 1));
            Teachers teacher2 = new Teachers("Asen asenov", new Disciplines("Sport", 4, 4));
           

            Console.WriteLine("st." + student.Name + ", ID:" + student.UniqueClassNumber);

            Console.WriteLine("teacher1: {0}", teacher1);
            Console.WriteLine("teacher2: {0}", teacher2);

            Console.WriteLine(school.ToString());
           
        }
    }
}
