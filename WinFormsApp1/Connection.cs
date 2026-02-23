using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Opiskelijahallinta
{
    internal class Connection
    {
        public string Address()
        {
            return "datasource=localhost; port=3306;username=root;password=;database=opiskelijat";
        }

        private MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=opiskelijat");
        
        public MySqlConnection CreateConnection()
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

