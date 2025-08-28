using Npgsql;

namespace EmployeeManagementUI
{
    public static class Database
    {
        private static string host = "localhost";
        private static string username = "postgres";
        private static string password = "postgres";
        private static string database = "EmployeeDB";

        public static string ConnectionString =>
            $"Host={host};Username={username};Password={password};Database={database}";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}
