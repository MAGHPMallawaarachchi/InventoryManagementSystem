﻿using InventoryManagementSystem.DataModels;
using System;
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
    public partial class AddCustomer : Form
    {
        private readonly MongoConnector _mongoConnector;
        public AddCustomer()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Add Customer Button
        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                customer_id = txtCustomerID.Text,
                name = txtName.Text,
                address = txtAddress.Text,
                city =  txtCity.Text,
                phone_no = txtContactNumber.Text
            };

            await _mongoConnector.Insert<Customer>("customers", customer);
        }

        //Discard button
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
