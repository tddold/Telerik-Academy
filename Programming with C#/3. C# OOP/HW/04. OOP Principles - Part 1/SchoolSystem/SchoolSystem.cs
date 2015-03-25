using School.Models;

namespace SchoolSystem
{    
    using System;    

    public class SchoolSystem
    {
        public static void Main()
        {
          
            Students student = new Students("Ivan Ivanov", 1);
            Teachers teacher = new Teachers("Pesho Peshev", new Disciplines("Mathematic", 1, 1));
            Disciplines discipline = new Disciplines("Hystory", 2, 2);

            Console.WriteLine(student.Name + " --> " + student.ClassID);

            Console.WriteLine(teacher.Name + " " + teacher.Disciplines);

            School newSchool = new School
                (
                    new Classes("11a", teacher)                
                );
        }
    }
}
