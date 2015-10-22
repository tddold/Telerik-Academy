namespace DifferentDataContext
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using EntityFrameworkModel;


    class Program
    {
        static void Main()
        {
            // 7.Try to open two different data contexts and perform concurrent changes on the same records.
            // What will happen at SaveChanges() ?
            // How to deal with it ?

            using (var northwind1 = new NorthwindEntities())
            {
                using (var northwind2 = new NorthwindEntities())
                {
                    Console.WriteLine(new string('-', 35));
                    Console.WriteLine("First context");
                    Console.WriteLine(new string('-', 35));
                    var person1 = northwind1.Employees.FirstOrDefault();
                    Console.WriteLine("Initial:{0}", person1.FirstName);
                    person1.FirstName = "Pesho";
                    Console.WriteLine("Change:{0}", person1.FirstName);

                    // Change by Entity state Unchanged Modified Detached
                    var dbEntry = northwind1.Entry(person1);
                    dbEntry.State = EntityState.Unchanged;
                    northwind1.SaveChanges();

                    Console.WriteLine(new string('-', 35));
                    Console.WriteLine("Second context");
                    Console.WriteLine(new string('-', 35));
                    var person2 = northwind2.Employees.FirstOrDefault();
                    Console.WriteLine("Initial:{0}", person2.FirstName);
                    person2.FirstName = "Peshev";
                    Console.WriteLine("Change:{0}", person2.FirstName);

                    northwind2.SaveChanges();
                }
            }
        }
    }
}
