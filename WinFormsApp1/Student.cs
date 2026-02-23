using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Opiskelijahallinta
{
    internal class Student
    {
        Connection connection = new Connection();
        
        public bool AddStudent(String firstName, String lastName, String phone, String email, int sNum)
        {
            MySqlCommand command = new MySqlCommand();
            String addQuery = "INSERT INTO yhteystiedot " +
                "(etunimi, sukunimi, puhelin, sähköposti, opiskelijanumero) " +
                "VALUES (@enm, @snm, @puh, @eml, @ono)";
            command.CommandText = addQuery;
            command.Connection = connection.CreateConnection();
            command.Parameters.Add("@enm", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@snm", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@puh", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@ono", MySqlDbType.UInt32).Value = sNum;

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

        public bool UpdateStudent(int oid, String firstName, String lastName, String phone, String email, int sNum)
        {
            MySqlCommand command = new MySqlCommand();
            String updateQuery = "UPDATE `yhteystiedot` SET `Etunimi` = @enm," +
                "`Sukunimi` = @snm, `puhelin` = @puh, `sähköposti` = @eml, `opiskelijanumero` = @ono " +
                "WHERE Oid = @oid";
            command.CommandText = updateQuery;
            command.Connection = connection.CreateConnection();
            command.Parameters.Add("@enm", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@snm", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@puh", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@ono", MySqlDbType.UInt32).Value = sNum;
            command.Parameters.Add("@Oid", MySqlDbType.UInt32).Value = oid;

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
        public bool DeleteStudent(string userName)
        {
            MySqlCommand command = new MySqlCommand();
            String deleteQuery = "DELETE FROM yhteystiedot WHERE oid = @unm";
            command.CommandText= deleteQuery;
            command.Connection = connection.CreateConnection();
            command.Parameters.Add("@unm", MySqlDbType.VarChar).Value = userName;

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

        public DataTable GetStudents()
        {
            string query = "SELECT oid, etunimi, sukunimi, puhelin, sähköposti, opiskelijanumero FROM yhteystiedot";
            MySqlCommand command = new MySqlCommand(query, connection.CreateConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
