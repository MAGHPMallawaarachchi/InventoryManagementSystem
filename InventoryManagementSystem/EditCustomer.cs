using InventoryManagementSystem.DataModels;
using InventoryManagementSystem.UserControls;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class EditCustomer : Form
    {
        private readonly MongoConnector _mongoConnector;
        private readonly UC_Customers _ucCustomers;
        private readonly string _customerId;

        public EditCustomer(UC_Customers ucCustomers, string customerId)
        {
            InitializeComponent();

            String connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");

            _ucCustomers = ucCustomers;
            _customerId = customerId;

            LoadCustomerData();
        }

        private async void LoadCustomerData()
        {
            var document = await _mongoConnector.GetByCustomerID(_customerId);

            txtCustomerID.Text = document.customer_id;
            txtName.Text = document?.name;
            txtAddress.Text = document.address;
            txtCity.Text = document.city;
            txtContactNumber.Text = document.phone_no;

        }


        //EditCustomer button
        private async void btnEditCustomer_Click(object sender, EventArgs e)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("customer_id", txtCustomerID.Text.ToString());

            BsonDocument updateCustomer = new BsonDocument
            {
                {"customer_id", _customerId},
                {"name",  txtName.Text.ToString()},
                {"address", txtAddress.Text.ToString()},
                {"city", txtCity.Text.ToString()},
                {"phone_no", txtCustomerID.Text.ToString()}
            };

            bool updatedSuccessfully = await _mongoConnector.UpdateDocumentAsync("customers", filter, updateCustomer);

            if (updatedSuccessfully)
            {
                MessageBox.Show("Customer details updated successfully.");
                _ucCustomers.RefreshCustomers();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error! Failed to update customer details.");
            }
        }


        //Discard button
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
