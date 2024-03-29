﻿using InventoryManagementSystem.DataModels;
using InventoryManagementSystem.UserControls;
using Siticone.Desktop.UI.WinForms;
using System.Configuration;
using Timer = System.Windows.Forms.Timer;

namespace InventoryManagementSystem
{
    public partial class AddCustomer : Form
    {
        private readonly MongoConnector _mongoConnector;
        private readonly UC_Customers _ucCustomers;
        ShowMessage showMessage = new ShowMessage();

        public AddCustomer(UC_Customers ucCustomers)
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
            _ucCustomers = ucCustomers;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            HideErrorLabels();
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Customer customer = new Customer
                {
                    customer_id = txtCustomerID.Text,
                    name = txtName.Text,
                    address = txtAddress.Text,
                    city = txtCity.Text,
                    phone_no = txtContactNumber.Text
                };

                try
                {
                    await _mongoConnector.Insert<Customer>("customers", customer);

                    // Empty the text boxes
                    txtCustomerID.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtCity.Text = "";
                    txtContactNumber.Text = "";

                    _ucCustomers.RefreshCustomers();

                    showMessage.ShowSuccessMessage("Customer added successfully!", this);
                }
                catch (Exception ex)
                {
                    showMessage.ShowErrorMessage(ex.Message, this);
                }
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            isValid = ValidateField(txtCustomerID, lblCustomerIDError, "Please enter the customer ID.") && isValid;
            isValid = ValidateField(txtName, lblNameError, "Please enter the name.") && isValid;
            isValid = ValidateField(txtAddress, lblAddressError, "Please enter the address.") && isValid;
            isValid = ValidateField(txtCity, lblCityError, "Please enter the city.") && isValid;
            isValid = ValidateField(txtContactNumber, lblContactNumberError, "Please enter the contact number.") && isValid;

            return isValid;
        }

        private bool ValidateField(SiticoneTextBox textBox, Label errorLabel, string errorMessage)
        {
            bool isValid = true;

            string contactNumber = txtContactNumber.Text.Replace(" ", "");

            if (string.IsNullOrEmpty(textBox.Text))
            {
                isValid = false;
                errorLabel.Text = errorMessage;
                errorLabel.Visible = true;
                textBox.BorderColor = ColorTranslator.FromHtml("#DA3E33");
            }
            else if (txtCustomerID.Text.Contains(" "))
            {
                isValid = false;
                lblCustomerIDError.Text = "Please enter a valid ID without spaces.";
                lblCustomerIDError.Visible = true;
                txtCustomerID.BorderColor = ColorTranslator.FromHtml("#DA3E33");
            }
            else if (IsCustomerIdAlreadyExists(txtCustomerID.Text))
            {
                isValid = false;
                lblCustomerIDError.Text = "The entered customer ID already exists";
                lblCustomerIDError.Visible = true;
                txtCustomerID.BorderColor = ColorTranslator.FromHtml("#DA3E33");
            }
            else if (contactNumber.Length != 10 || !contactNumber.All(char.IsDigit))
            {
                isValid = false;
                lblContactNumberError.Text = "Please enter a valid contact number.";
                lblContactNumberError.Visible = true;
                txtContactNumber.BorderColor = ColorTranslator.FromHtml("#DA3E33");
            }
            else
            {
                errorLabel.Visible = false;
            }

            return isValid;
        }

        private bool IsCustomerIdAlreadyExists(string customer_id)
        {
            bool isCustomerIdAlreadyExists = false;
            var customers = _mongoConnector.GetCustomers();

            foreach (var customer in customers)
            {
                if (customer.customer_id == customer_id)
                {
                    isCustomerIdAlreadyExists = true;
                    break;
                }
            }

            return isCustomerIdAlreadyExists;
        }

        private void HideErrorLabels()
        {
            lblCustomerIDError.Visible = false;
            lblNameError.Visible = false;
            lblAddressError.Visible = false;
            lblCityError.Visible = false;
            lblContactNumberError.Visible = false;
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            lblCustomerIDError.Visible = false;
            txtCustomerID.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblNameError.Visible = false;
            txtName.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            lblAddressError.Visible = false;
            txtAddress.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            lblCityError.Visible = false;
            txtCity.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {
            lblContactNumberError.Visible = false;
            txtContactNumber.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }
    }
}

