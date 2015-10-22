namespace _06_07.ExcelOLEDB
{
    using System;
    using System.Data.OleDb;
    class Program
    {
        static void Main()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\excel\trainers.xlsx;Extended Properties=""Excel 12.0 Xml; HDR = YES; IMEX = 1"";";

            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();

            using (dbConnection)
            {
                // 6.Create an Excel file with 2 columns: name and score:.
                // Write a program that reads your MS Excel file through the OLE DB data provider and displays the name and score row by row.
                GetDataFromExcelFile(dbConnection);
                Console.WriteLine(new string('-', 30));

                // 7.Implement appending new rows to the Excel file.
                AddingNewRowToExcelFile(dbConnection, "Ivan Vaszov", 45);
                AddingNewRowToExcelFile(dbConnection, "Jivko Georgiev", 24);
                Console.WriteLine(new string('-', 30));
            }
        }

        private static void AddingNewRowToExcelFile(OleDbConnection dbConnection, string name, int score)
        {
            OleDbCommand cmd = new OleDbCommand(
                string.Format("INSERT INTO [Sheet1$] (Name, Score) VALUES('{0}', '{1}')", name, score), dbConnection
                );
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Row inserted successfully.");
            }
            catch (OleDbException ex)
            {

                Console.WriteLine("Excel Error occurred: " + ex);
            }
        }

        private static void GetDataFromExcelFile(OleDbConnection dbConnection)
        {
            string xlxStringCommand = @"
                                        SELECT *
                                        FROM [Sheet1$]";

            OleDbCommand xslCommand = new OleDbCommand(xlxStringCommand, dbConnection);
            OleDbDataReader reader = xslCommand.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];
                    Console.WriteLine("{0} -> {1}", name, score);
                }
            }
        }
    }
}
