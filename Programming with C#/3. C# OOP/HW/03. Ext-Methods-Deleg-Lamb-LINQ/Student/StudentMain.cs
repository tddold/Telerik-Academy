
#region Task
/*Problem 9. Student groups
 * Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), 
 * GroupNumber.
 * Create a List<Student> with sample students. Select only the students that are from group 
 * number 2.
 * Use LINQ query. Order the students by FirstName.
 * Problem 10. Student groups extensions
 * Implement the previous using the same query expressed with extension methods.
 * Problem 11. Extract students by email
 * Extract all students that have email in abv.bg.
 * Use string methods and LINQ.
 * Problem 12. Extract students by phone
 * Extract all students with phones in Sofia.
 * Use LINQ.
 * Problem 13. Extract students by marks
 * Select all students that have at least one mark Excellent (6) into a new anonymous class that 
 * has properties – FullName and Marks.
 * Use LINQ.
 * Problem 14. Extract students with two marks
 * Write down a similar program that extracts the students with exactly two marks "2".
 * Use extension methods.
 * Problem 15. Extract marks
 * Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as 
 * their 5-th and 6-th digit in the FN).
 * Problem 16.* Groups
 * Create a class Group with properties GroupNumber and DepartmentName.
 * Introduce a property GroupNumber in the Student class.
 * Extract all students from "Mathematics" department.
 * Use the Join operator.*/

#endregion

namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net.Mail;

    class StudentMain
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Ivan",
                           "Ivanov",
                           "1000101",
                           "+35988123456",
                            new MailAddress ("ivan@abv.bg"),
                            new List<int> { 6, 5, 6},
                            new Group(1, "Mathematics")),
               new Student ("Pesho",
                           "Peshev",
                           "1000102",
                           "+35988123457",
                           new MailAddress ("pesho@dir.bg"),
                           new List<int> { 4, 3, 4},
                           new Group(2, "History")),
               new Student ("Asen",
                           "Asenow",
                           "1000103",
                           "+35988123458",
                           new MailAddress ("asen@abv.bg"),
                           new List<int> { 5, 5, 5},
                           new Group(1, "Mathematics")),
               new Student ("Gosho",
                           "Goshev",
                           "1000104",
                           "+35988123459",
                           new MailAddress ("gosho@dir.bg"),
                           new List<int> { 4, 5, 6},
                           new Group(3, "Informatica")),
               new Student ("Stamat",
                           "Stamatov",
                           "1000105",
                           "+35988123467",
                           new MailAddress ("stamat@abv.bg"),
                           new List<int> { 2, 4, 5},
                           new Group(3, "Informatica")),
               new Student ("Tosho",
                           "Toshev",
                           "1000106",
                           "+3592123477",
                           new MailAddress ("tosho@dir.bg"),
                           new List<int> { 5, 6, 4},                            
                           new Group(1, "Mathematics")),
            };

            // all students from group 2
            #region Problem 9 - 10. All students from group 2
            // with LINQ (Language INtegrated Query)
            var studentsGroupTwoLinq =
                from st in students
                where st.Group.GroupNumber == 2
                orderby st.FirstName
                select st;


            //with exttention methods
            var studentsGroupTwoWithExt = students
               .Where(x => x.Group.GroupNumber == 2)
               .OrderBy(x => x.FirstName)
               .Select(s => s).ToList();

            Console.WriteLine("Using LINQ - all students from group 2:");
            PrintSeparateLine();
            Console.WriteLine(string.Join("\n\n", studentsGroupTwoLinq));

            Console.WriteLine();
            PrintSeparateDoubleLine();
            Console.WriteLine();

            Console.WriteLine("Using extensions methods - all students from group 2:");
            PrintSeparateLine();
            Console.WriteLine(string.Join("\n\n", studentsGroupTwoWithExt));

            #endregion

            #region Problem 11. Extract students by email

            // Select all students with mail in abv
            var studentsByEmail =
                from st in students
                where st.Email.ToString().Substring(st.Email.ToString().IndexOf('@') + 1, 6) == "abv.bg"
                select st;

            Console.WriteLine();
            PrintSeparateDoubleLine();
            Console.WriteLine();

            Console.WriteLine("All students with mail in abv");
            PrintSeparateLine();
            Console.WriteLine(string.Join("\n\n", studentsByEmail));

            #endregion

            #region Problem 12. Extract students by phone

            // Select all students with phones in Sofia
            var studentsFromSofia =
                from st in students
                where st.Phone.StartsWith("+3592")
                select st;

            Console.WriteLine();
            PrintSeparateDoubleLine();
            Console.WriteLine();

            Console.WriteLine("All students with phones in Sofia.");
            PrintSeparateLine();
            Console.WriteLine(string.Join("\n\n", studentsFromSofia));

            #endregion

            #region Problem 13. Extract students by marks

            // Select all students that have at least one mark Excellent (6)
            var studentsExcellent =
                from st in students
                where st.Marks.Contains(6)
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = string.Join(" ", st.Marks)
                };

            Console.WriteLine();
            PrintSeparateDoubleLine();
            Console.WriteLine();

            Console.WriteLine("All students that have at least one mark Excellent (6).");
            PrintSeparateLine();
            Console.WriteLine(string.Join("\n\n", studentsExcellent));

            #endregion

            #region Problem 14. Extract students with two marks


            // extracts the students with exactly two marks "2".
            var studentsTwoMarks = students
                .Where(x => x.Marks.Contains(2))
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    Marks = string.Join(" ", x.Marks)
                });

            Console.WriteLine();
            PrintSeparateDoubleLine();
            Console.WriteLine();

            Console.WriteLine("All students that have with two marks \"2\".");
            PrintSeparateLine();
            Console.WriteLine(string.Join("\n\n", studentsTwoMarks));

            #endregion

            #region Problem 15. Extract marks
            // Extract all Marks of the students that enrolled in 2006

            var studentsAllMark = students
                .Where(x => x.FacultyNumber[5] == '0' && x.FacultyNumber[6] == '6')
                .Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    FN = x.FacultyNumber,
                    Marks = string.Join(" ", x.Marks)
                });

            Console.WriteLine();
            PrintSeparateDoubleLine();
            Console.WriteLine();

            Console.WriteLine("All marks of students enrolled in 2006.");
            PrintSeparateLine();
            Console.WriteLine(string.Join("\n\n", studentsAllMark));

            #endregion

            #region Problem 16.* Groups

            // Groups
            Group gr1 = new Group(1, "Mathematics");
            Group gr2 = new Group(2, "History");
            Group gr3 = new Group(3, "Informatica");

            List<Group> groups = new List<Group>() { gr1, gr2, gr3 };

            var studentsMath =
                from gr in groups
                where gr.GroupNumber == 1
                join st in students
                on gr.GroupNumber equals st.Group.GroupNumber
                select new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Department = gr.DepartamenrName
                };


            Console.WriteLine();
            PrintSeparateDoubleLine();
            Console.WriteLine();

            Console.WriteLine("All students from \"Mathematics\" department.");
            PrintSeparateLine();
            Console.WriteLine(string.Join("\n\n", studentsMath));

            #endregion

            #region Problem 18. Grouped by GroupNumber
            // Problem 18. Grouped by GroupNumber

            var groupStudent =
                from student in students
                group student by student.Group.GroupNumber;

            var grouped = new List<string>();

            foreach (var group in groupStudent)
            {
                grouped.Add(string.Format("group {0}\n{1}\n", group.ElementAt(0).Group.GroupNumber,
                    string.Join("\n\n", group)));
            }

            Console.WriteLine();
            PrintSeparateDoubleLine();
            Console.WriteLine();

            Console.WriteLine("Problem 18. Grouped by GroupNumber");
            PrintSeparateLine();

            Console.WriteLine(string.Join(Environment.NewLine, grouped));


            #endregion

            #region Problem 19. Grouped by GroupName extensions
            // Problem 19. Grouped by GroupName extensions
            // Rewrite the previous using extension methods.

            var groupStudentByExt = students
                .GroupBy(x => x.Group.GroupNumber,
                (groupNumber, student) => new
                {
                    GroupName = groupNumber,
                    student = student
                });

            foreach (var group in groupStudentByExt)
            {               
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", group.GroupName,
                    string.Join("\r\n\r\n", group.student));
            }


            Console.WriteLine();
            PrintSeparateDoubleLine();
            Console.WriteLine();

            #endregion

        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }

        public static void PrintSeparateDoubleLine()
        {
            Console.WriteLine(new string('=', 40));
        }
    }
}
