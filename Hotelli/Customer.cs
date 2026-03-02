using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelli
{
    static internal class Customer
    {
        public static DataTable GetCustomers()
        {
            Connection connection = new Connection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT customerid, firstname, lastname, address, postcode, postalarea FROM customers", connection.GetConnection());
            connection.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public static bool AddCustomer(CustomerInfo customer)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand("INSERT INTO customers " +
                                                    "(firstname, lastname, address, postcode, postalarea, username, password) " +
                                                    "VALUES (@fn, @ln, @addr, @pscode, @psarea, @usn, @pw); ", connection.GetConnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = customer.FirstName;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = customer.LastName;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = customer.Address;
            command.Parameters.Add("@pscode", MySqlDbType.VarChar).Value = customer.Postcode;
            command.Parameters.Add("@psarea", MySqlDbType.VarChar).Value = customer.City;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = customer.Username;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = customer.Password;

            connection.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }

        public static bool DeleteCustomer(string id)
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand("DELETE FROM customers WHERE customerid = @id", connection.GetConnection());

            command.Parameters.AddWithValue("@id", id);

            connection.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }

        public static bool UpdateCustomer(CustomerInfo customer, string id)
        {
            Connection connection = new Connection();
            string query = @"UPDATE customers 
                 SET firstname = @fn, 
                     lastname = @ln, 
                     address = @addr, 
                     postcode = @pc, 
                     postalarea = @pa, 
                     username = @user, 
                     `password` = @pass 
                 WHERE customerid = @id";
            MySqlCommand command = new MySqlCommand(query, connection.GetConnection());

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@fn", customer.FirstName);
            command.Parameters.AddWithValue("@ln", customer.LastName);
            command.Parameters.AddWithValue("@addr", customer.Address);
            command.Parameters.AddWithValue("@pc", customer.Postcode);
            command.Parameters.AddWithValue("@pa", customer.City);
            command.Parameters.AddWithValue("@user", customer.Username);
            command.Parameters.AddWithValue("@pass", customer.Password);

            connection.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }
    }
}
