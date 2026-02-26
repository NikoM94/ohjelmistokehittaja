using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelli
{
    public partial class HotelCustomerFM : Form
    {
        DataTable customers = new DataTable();
        public HotelCustomerFM()
        {
            InitializeComponent();
        }

        private void HotelCustomerFM_Load(object sender, EventArgs e)
        {
            GetAllCustomers();
            CustomerDG.DataSource = customers;    
        }

        private void GetAllCustomers()
        {
            Connection connection = new Connection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT firstname, lastname, address, postcode, postalarea FROM customers", connection.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            customers = table;
        }

        private void CustomerEmptyFieldsBT_Click(object sender, EventArgs e)
        {
            CustomerFirstNameTB.Text = "";
            CustomerLastNameTB.Text = "";
            CustomerAddressTB.Text = "";
            CustomerPostalCodeTB.Text = "";
            CustomerPostalAreaTB.Text = "";
            CustomerUsernameTB.Text = "";
            CustomerPasswordTB.Text = "";
        }

        private void CustomerAddBT_Click(object sender, EventArgs e)
        {
            string firstName = CustomerFirstNameTB.Text;
            string lastName = CustomerLastNameTB.Text;
            string address = CustomerAddressTB.Text;
            string postalCode = CustomerPostalCodeTB.Text;
            string postalArea = CustomerPostalAreaTB.Text;
            string userName = CustomerUsernameTB.Text;
            string password = CustomerPasswordTB.Text;
            ValidFields validFields = InputValidator.ValidateUserRegistration(firstName, lastName, address, postalCode, postalArea, userName, password);
            string errorMsg = BuildErrorMessage(validFields);

            if (errorMsg.Length > 0)
            {
                //Show messagebox here with error msg
                return;
            }

            Connection connection = new Connection();
            MySqlCommand command = new MySqlCommand("INSERT INTO customers " +
                                                    "(firstname, lastname, address, postalcode, postalarea) " +
                                                    "VALUES (@fn, @ln, @addr, @pscode, @psarea); ", connection.GetConnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pscode", MySqlDbType.VarChar).Value = postalCode;
            command.Parameters.Add("@psarea", MySqlDbType.VarChar).Value = postalArea;
        }
        
        private string BuildErrorMessage(ValidFields fields)
        {
            StringBuilder sb = new StringBuilder();
            if (!fields.FirstName)
            {
                sb.Append("invalid first name, ");
            }
            if (!fields.LastName)
            {
                sb.Append("invalid last name, ");
            }
            if (!fields.Address)
            {
                sb.Append("invalid address, ");
            }
            if (!fields.Postcode)
            {
                sb.Append("invalid post code, ");
            }
            if (!fields.City)
            {
                sb.Append("invalid city, ");
            }
            if (!fields.Username)
            {
                sb.Append("invalid invalid user name, ");
            }
            if (!fields.Password)
            {
                sb.Append("invalid password, ");
            }
            
            if (sb.ToString().Length > 0)
            {
                return sb.ToString().Trim();
            }
            return "";
        }
    }
}
