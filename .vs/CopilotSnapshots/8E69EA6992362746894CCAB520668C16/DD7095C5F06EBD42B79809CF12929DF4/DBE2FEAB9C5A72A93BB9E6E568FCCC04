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

struct CustomerInfo
{
    public string FirstName;
    public string LastName;
    public string Address;
    public string Postcode;
    public string City;
    public string Username;
    public string Password;
}

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
            CustomerDG.DataSource = Customer.GetCustomers();    
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
            CustomerInfo newCustomer = new CustomerInfo
            {
                FirstName = CustomerFirstNameTB.Text,
                LastName = CustomerLastNameTB.Text,
                Address = CustomerAddressTB.Text,
                Postcode = CustomerPostalCodeTB.Text,
                City = CustomerPostalAreaTB.Text,
                Username = CustomerUsernameTB.Text,
                Password = CustomerPasswordTB.Text
            };
            ValidFields validFields = InputValidator.ValidateUserRegistration(newCustomer);
            string errorMsg = InputValidator.BuildErrorMessage(validFields);

            if (errorMsg.Length > 0)
            {
                MessageBox.Show($"Fields missing or invalid: {errorMsg}", "Missing or invalid fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = Customer.AddCustomer(newCustomer);

            if (!result)
            {
                MessageBox.Show("Failed to execute SQL query", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Customer added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            customers = Customer.GetCustomers();
            CustomerDG.DataSource = customers;
        }
        

        private void CustomerDeleteBT_Click(object sender, EventArgs e)
        {
            if (CustomerDG.CurrentRow == null)
            {
                return;
            }

            string? id = CustomerDG.CurrentRow.Cells["customerid"].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("ID was null", "NULL value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = Customer.DeleteCustomer(id);

            if (!result)
            {
                MessageBox.Show("Failed to execute SQL query", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Customer deleted succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            customers = Customer.GetCustomers();
            CustomerDG.DataSource = customers;
        }

        private void CustomerUpdateBT_Click(object sender, EventArgs e)
        {
            if (CustomerDG.CurrentRow == null)
            {
                return;
            }

            string? id = CustomerDG.CurrentRow.Cells["customerid"].Value.ToString();

            if (id == null)
            {
                MessageBox.Show("ID was null", "NULL value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CustomerInfo customerToUpdate = new CustomerInfo
            {
                FirstName = CustomerFirstNameTB.Text,
                LastName = CustomerLastNameTB.Text,
                Address = CustomerAddressTB.Text,
                Postcode = CustomerPostalCodeTB.Text,
                City = CustomerPostalAreaTB.Text,
                Username = CustomerUsernameTB.Text,
                Password = CustomerPasswordTB.Text
            };

            ValidFields validFields = InputValidator.ValidateUserRegistration(customerToUpdate);
            string errorMsg = InputValidator.BuildErrorMessage(validFields);

            if (errorMsg.Length > 0)
            {
                MessageBox.Show($"Fields missing or invalid: {errorMsg}", "Missing or invalid fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = Customer.UpdateCustomer(customerToUpdate, id);

            if (!result)
            {
                MessageBox.Show("Failed to execute SQL query", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Customer updated succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            customers = Customer.GetCustomers();
            CustomerDG.DataSource = customers;
        }

        private void CustomerDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var customerValues = CustomerDG.Rows[e.RowIndex].Cells;
            CustomerFirstNameTB.Text = customerValues["firstname"].Value.ToString();
            CustomerLastNameTB.Text = customerValues["lastname"].Value.ToString();
            CustomerAddressTB.Text = customerValues["address"].Value.ToString();
            CustomerPostalCodeTB.Text = customerValues["postcode"].Value.ToString();
            CustomerPostalAreaTB.Text = customerValues["postalarea"].Value.ToString();
        }
    }
}
