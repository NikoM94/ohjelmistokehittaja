using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotelli
{
    internal class Connection
    {
        private static string connectionString = "datasource=localhost; port=3306;username=root;password=;database=hotel";

        private MySqlConnection connection = new MySqlConnection(connectionString);
        
        public MySqlConnection GetConnection()
        {
             return connection;
        }

        public void OpenConnection()
        {
             connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open) 
            { 
                 connection.Close();
            }
        }
    }
}
