namespace DatabaseClone
{
    using System;
    using System.Configuration;
    using EntityFrameworkModel;
    class Program
    {
        static void Main()
        {
            // 6.Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext.
            // Find for the API for schema generation in MSDN or in Google.

            // Get the application configuration file.
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Create a connection string element and save it to the configuration file.

            // Create a connection string element.
            ConnectionStringSettings csSetings = new ConnectionStringSettings(
                "NorthwindEntities",
                @"metadata=res://*/NorthwindModel.csdl|res://*/NorthwindModel.ssdl|res://*/NorthwindModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.\SQLEXPRESS;initial catalog=NorthwindTwin;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" , "System.Data.EntityClient");

            // Get the connection strings section.
            ConnectionStringsSection csSection = config.ConnectionStrings;

            //// Add the new element.
            //csSection.ConnectionStrings.Add(csSetings);

            // Save the configuration file.
            config.Save(ConfigurationSaveMode.Modified);

            using (var northwindEntities = new NorthwindEntities())
            {
                var result = northwindEntities.Database.CreateIfNotExists();
                Console.WriteLine("Database NorthwindEntities created: {0} ", result ? "YES" : "NO");
            }
        }
    }
}
