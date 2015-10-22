namespace _01_05._08.ReteiveDataFromMSSQLDB
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    public class Program
    {
        internal static void Main()
        {
            SqlConnection dbConnection = new SqlConnection(
                "Server=.\\SQLEXPRESS;" +
                "Database = Northwind;" +
                "Integrated Security=true");

            dbConnection.Open();
            using (dbConnection)
            {

                // 1.Write a program that retrieves from the Northwind sample database in MS SQL Server the number of rows in the Categories table.
                RetrieveNumberOfRows(dbConnection);
                Console.WriteLine(new string('-', 30));


                // 2.Write a program that retrieves the name and description of all categories in the Northwind DB.
                RetrieveNameAndDescription(dbConnection);
                Console.WriteLine(new string('-', 30));

                // 3.Write a program that retrieves from the Northwind database all product categories and the names of the products in each category.
                // Can you do this with a single SQL query (with table join)?
                RetrieveAllProductCategoriesAndProducts(dbConnection);
                Console.WriteLine(new string('-', 30));

                // 4.Write a method that adds a new product in the products table in the Northwind database.
                // Use a parameterized SQL command.
                int newProduct = AddNewProductToDBTable(dbConnection, "Some", 1, 1, "5x10", 15.00M, 0, 0, 0, true);
                Console.WriteLine("Inserted new product with Id: {0}", newProduct);
                Console.WriteLine(new string('-', 30));


                // 5.Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.
                RetrieveImagesFromCategories(dbConnection);
                Console.WriteLine("Stored JPG files in folder images");
                Console.WriteLine(new string('-', 30));

                // 8.Write a program that reads a string from the console and finds all products that contain this string.
                // Ensure you handle correctly characters like ', %, ", \ and _.
                // http://www.orafaq.com/faq/how_does_one_escape_special_characters_when_writing_sql_queries

                Console.Write("Please enter text to search product:");
                string input = Console.ReadLine();
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Products that contain: {0}", input);
                SearchAllProductsThatContainString(dbConnection, input);
            }
        }

        private static void SearchAllProductsThatContainString(SqlConnection dbConnection, string input)
        {
            input = EscapeInputString(input);

            string sqlStringCommand = string.Format(@"
                    SELECT ProductName
                    FROM Products
                    WHERE ProductName LIKE '%{0}%'", input);

            SqlCommand allProducts = new SqlCommand(sqlStringCommand, dbConnection);
            SqlDataReader reader = allProducts.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string productName = (string)reader["ProductName"];
                    Console.WriteLine("{0}", productName);
                }
            }
        }

        private static string EscapeInputString(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\'')
                {
                    input = input.Substring(0, 1) + "'" + input.Substring(i, input.Length - 1);
                    i++;
                }

                if (input[i] == '_')
                {
                    input = input.Substring(0, 1) + "/" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '%')
                {
                    input = input.Substring(0, 1) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '&')
                {
                    input = input.Substring(0, 1) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }

            }

            return input;
        }

        private static void RetrieveImagesFromCategories(SqlConnection dbConnection)
        {
            string sqlStringCommand =
                 "SELECT CategoryName, Picture FROM Categories";
            SqlCommand allPictures = new SqlCommand(sqlStringCommand, dbConnection);

            SqlDataReader reader = allPictures.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    categoryName = categoryName.Replace('/', '_');
                    byte[] fileContents = (byte[])reader["Picture"];
                    string fileName = string.Format(@"..\..\images\{0}.jpg", categoryName);
                    WriteBinaryFile(fileName, fileContents);
                }
            }
        }

        private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 78, fileContents.Length - 78);
            }
        }

        private static int AddNewProductToDBTable(
            SqlConnection dbConnection,
            string ProductName,
            int SupplierID,
            int CategoryID,
            string QuantityPerUnit,
            decimal UnitPrice,
            int UnitsInStock,
            int UnitsOnOrder,
            int ReorderLevel,
            bool Discontinued)
        {
            string sqlStringCommand = @"
                   INSERT INTO Products(
                   ProductName, SupplierID, CategoryID,
                   QuantityPerUnit, UnitPrice, UnitsInStock,
                   UnitsOnOrder, ReorderLevel, Discontinued)
                   VALUES(@productName, @supplierID, @categoryID,
                   @quantityPerUnit, @unitPrice, @unitsInStock,
                   @unitsOnOrder, @reorderLevel, @discontinued)";
            SqlCommand insertProduct = new SqlCommand(sqlStringCommand, dbConnection);

            insertProduct.Parameters.AddWithValue("@productName", ProductName);
            insertProduct.Parameters.AddWithValue("@supplierID", SupplierID);
            insertProduct.Parameters.AddWithValue("@categoryID", CategoryID);
            insertProduct.Parameters.AddWithValue("@quantityPerUnit", QuantityPerUnit);
            insertProduct.Parameters.AddWithValue("@unitPrice", UnitPrice);
            insertProduct.Parameters.AddWithValue("@unitsInStock", UnitsInStock);
            insertProduct.Parameters.AddWithValue("@unitsOnOrder", UnitsOnOrder);
            insertProduct.Parameters.AddWithValue("@reorderLevel", ReorderLevel);
            insertProduct.Parameters.AddWithValue("@discontinued", Discontinued);

            insertProduct.ExecuteNonQuery();

            SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", dbConnection);
            int insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();

            return insertedRecordId;
        }

        private static void RetrieveAllProductCategoriesAndProducts(SqlConnection dbConnection)
        {
            string sqlStringCommand = @"
                    SELECT c.CategoryName, p.ProductName
                    FROM Categories c
                    JOIN Products p
                    ON c.CategoryID = p.CategoryID
                    ORDER BY c.CategoryName";
            SqlCommand allProductsInCategory = new SqlCommand(sqlStringCommand, dbConnection);
            SqlDataReader reader = allProductsInCategory.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string productName = (string)reader["ProductName"];
                    Console.WriteLine("{0} -> {1}", categoryName, productName);
                }
            }
        }

        private static void RetrieveNameAndDescription(SqlConnection dbConnection)
        {
            string sqlStringCommand = "SELECT [CategoryName], [Description] FROM Categories";
            SqlCommand allNames = new SqlCommand(sqlStringCommand, dbConnection);
            SqlDataReader reader = allNames.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0} -> {1}", categoryName, description);
                }
            }
        }

        private static void RetrieveNumberOfRows(SqlConnection dbConnection)
        {
            string sqlStringCommand = "SELECT COUNT(*) FROM Categories";

            SqlCommand sqlCommandCount = new SqlCommand(sqlStringCommand, dbConnection);
            int rowCount = (int)sqlCommandCount.ExecuteScalar();
            Console.WriteLine("Rows count: {0}", rowCount);
        }
    }
}
