namespace StudentSystem.ConsoleClient
{
    using System;
    using StudentSystem.Data;

    public class StartUp
    {
        private static readonly StudentSystemData StudentSystemData = new StudentSystemData();
        private static readonly DatabaseSeeder DatabaseSeeder = new DatabaseSeeder(StudentSystemData);

        public static void Main()
        {
            // IMPORTANT: Change connection string in "StudentSystem.Common/ConnectionStrings"
            Console.Write("Seeding data in database...");
            DatabaseSeeder.SeedDataToDatabase();
            Console.WriteLine("\rData were seeded successfully!");
        }
    }
}
