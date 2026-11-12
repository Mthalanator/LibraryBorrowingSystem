using System.Data.SqlClient;

namespace LibraryBorrowingSystem
{
    public static class Database
    {
        // Connection string set to (localdb)\MSSQLLocalDB and database "library"
        private static string connection_string = @"Server=(localdb)\MSSQLLocalDB;Database=library;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connection_string);
        }
    }
}