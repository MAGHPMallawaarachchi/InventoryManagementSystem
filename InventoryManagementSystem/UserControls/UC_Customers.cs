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
    public partial class UC_Customers : UserControl
    {
        private readonly MongoConnector _mongoConnector;
        public UC_Customers()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private async void CustomersLoad()
        {
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            var documents = await _mongoConnector.GetAllCustomers();

            dgvCustomers.Rows.Clear(); // Clear existing data in the grid view

            foreach (var document in documents)
            {
                dgvCustomers.Rows.Add(new object[] {
                    document.customer_id!,
                    document.name!,
                    document.address!,
                    document.city!,
                    document.phone_no!,
                });
            }

            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                row.Height = 50;
            }

            dgvCustomers.CurrentCell = null;
        }

        public void RefreshCustomers()
        {
            CustomersLoad();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(this);
            addCustomer.ShowDialog();
        }

        private void UC_Customers_Load(object sender, EventArgs e)
        {
            CustomersLoad();
        }

        private async void dgvCustomers_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewButtonCell buttonCell)
                {


                    // Perform edit action
                    if (buttonCell.OwningColumn.Index == 6)     // Edit button is in 6th column
                    {

                        // Get the selected row
                        var selectedRow = dgvCustomers.Rows[e.RowIndex];

                        // Get the customer ID from the selected row
                        string customerId = selectedRow.Cells[0].Value.ToString();

                        // Create a new instance of the EditCustomer form
                        var editCustomer = new EditCustomer(this, customerId);

                        // Show the Editform
                        editCustomer.ShowDialog();

                    }



                    // Perform delete action
                    else if (buttonCell.OwningColumn.Index == 7)    // Delete button is in 7th column
                    {
                        // Get the selected row
                        var selectedRow = dgvCustomers.Rows[e.RowIndex];

                        // Display confirmation dialog to confirm delete action
                        var result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // If user confirms delete action
                        if (result == DialogResult.Yes)
                        {
                            // Remove the row from the DataGridView
                            dgvCustomers.Rows.Remove(selectedRow);

                            // Perform delete action
                            // Get the ID of the record to delete from the selected row
                            String idToDelete = (String)selectedRow.Cells["customer_id"].Value;

                            // Call the DeleteCustomer method in your data access layer to delete the record
                            bool deletedSuccessfully = await _mongoConnector.DeleteCustomer(idToDelete);


                            if (deletedSuccessfully)
                            {
                                // Display a success message
                                MessageBox.Show("Record deleted successfully.");

                                // Refresh the DataGridView to reflect the changes
                                RefreshCustomers();
                            }
                            else
                            {
                                // Display an error message if the record could not be deleted
                                MessageBox.Show("Error! deleting process is not successful.");
                            }

                        }
                    }
                }
            }
        }
    }
}
