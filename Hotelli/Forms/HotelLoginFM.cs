using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Hotelli.Data;
using BCrypt.Net;

namespace Hotelli.Forms
{
    public partial class HotelLoginFM : Form
    {
        public HotelLoginFM()
        {
            InitializeComponent();
        }

        private DataTable GetCredentials(string userName, string password)
        {
            Connection connection = new Connection();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand();
            string query = "SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = connection.GetConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            connection.OpenConnection();
            table.Columns.Add("username", typeof(string));
            using (var reader = command.ExecuteReader()) 
            { 
                if (reader.Read()) {
                    string username = reader.GetString("username");
                    string hash = reader.GetString("password");

                    if (BCrypt.Net.BCrypt.Verify(password, hash))
                    {
                        table.Rows.Add(username);
                    }
                }
            }
            return table;
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            string userName = UserNameTB.Text.Trim();
            string password = PasswordTB.Text.Trim();
            if (!EmptyUserName(userName)) 
            {
                MessageBox.Show("Please enter a username", "Empty username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!EmptyPassword(password)) 
            {
                MessageBox.Show("Please enter a password", "Empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string storedHash = GetPasswordHash(userName);

            if (storedHash != null && BCrypt.Net.BCrypt.Verify(password, storedHash))
            {
                this.Hide();
                HotelMainView mainFM = new HotelMainView();
                mainFM.Show();
            }
            else if (userName == "admin" && storedHash == null)
            {
                if (CreateAdminAccount())
                {
                    MessageBox.Show("Admin account created. Please log in again.", "Success");
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetPasswordHash(string username)
        {
            Connection connection = new Connection();
            string query = "SELECT password FROM users WHERE username = @usrn";
            MySqlCommand command = new MySqlCommand(query, connection.GetConnection());
            command.Parameters.AddWithValue("@usrn", username);

            connection.OpenConnection();
            object result = command.ExecuteScalar();
            connection.CloseConnection();

            return result?.ToString(); 
        }

        public bool DoesUserExist(string username)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @user";
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand(query, connection.GetConnection());

            command.Parameters.AddWithValue("@user", username);

            connection.OpenConnection();
            long count = (long)command.ExecuteScalar();
            connection.CloseConnection();

            return count > 0;
        }

        private bool CreateAdminAccount()
        {
            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand();
            String query = "INSERT INTO users (username, password) VALUES (@usrn, @pwhash)";

            string passwordHash = BCrypt.Net.BCrypt.HashPassword("admin");

            command.CommandText = query;
            command.Connection = connection.GetConnection();

            command.Parameters.Add("@usrn", MySqlDbType.VarChar).Value = "admin";
            command.Parameters.Add("@pwhash", MySqlDbType.VarChar).Value = passwordHash;

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

        private bool EmptyPassword(string password)
        {
            return password != null && !password.Equals("");
        }

        private bool EmptyUserName(string userName)
        {
            return userName != null && !userName.Equals("");
        }
    }
}
