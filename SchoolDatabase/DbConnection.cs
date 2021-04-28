using System;
using System.Data.SqlClient;

namespace SchoolDatabase
{
    public class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server=BT1704547\\MSSQLSERVER01; Database=TestShoolDb; Integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
