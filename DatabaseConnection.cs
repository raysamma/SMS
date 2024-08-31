using System;
using System.Configuration;

namespace SMS
{
    public static class DatabaseConnection
    {
        // Retrieves the connection string from the Web.config file
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;
        }

        public static string ConnectionString { get; set; }
    }
}
