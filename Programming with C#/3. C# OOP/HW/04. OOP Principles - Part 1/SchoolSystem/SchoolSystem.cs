using School.Models;

namespace SchoolSystem
{
    using System;

    public class SchoolSystem
    {
        public static void Main()
        {
          
            Students student = new Students("Ivan Ivanov", 1);
            Teachers teacher1 = new Teachers("Pesho Peshev", new Disciplines("Mathematic", 1, 1)); 
              Teachers teacher2 = new Teachers("Asen asenov", new Disciplines("Sport", 4, 4));
            
            
            Disciplines discipline = new Disciplines("Hystory", 2, 2);

            Console.WriteLine("st." + student.Name + ", ID:" + student.ClassID);

            Console.WriteLine("{0}",teacher1);
            Console.WriteLine(teacher2);

            // Console.WriteLine("{0}", string.Join(", ", teacher1.Disciplines));

            Classes class11a = new Classes("11a", "proba", teacher1);

            School.Models.School newSchool = new School.Models.School();

           // newSchool.AddClass(class11a);

            Console.WriteLine(newSchool.ToString());
        }
    }
}
