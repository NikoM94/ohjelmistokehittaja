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

namespace Hotelli
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
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = connection.GetConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);
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

            if (GetCredentials(userName, password).Rows.Count > 0)
            {
                this.Hide();
                HotelMainView mainFM= new HotelMainView();
                mainFM.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Incorrect credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
