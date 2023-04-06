using System.Configuration;
using System.Windows.Forms;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_Customers : UserControl
    {
        private readonly MongoConnector _mongoConnector;
        ShowMessage showMessage = new ShowMessage();

        public UC_Customers()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");

            CustomersLoad();
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

            editbtn.Width = 30;
            deletebtn.Width = 30;
            address.Width = 400;
            customer_id.Width = 200;

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

        private void UC_Customer_Load(object sender, EventArgs e)
        {
            CustomersLoad();
        }

        private async void dgvCustomers_CellContentClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewImageCell buttonCell)
                {
                    // Perform edit action
                    if (buttonCell.OwningColumn.Index == 5)     // Edit button is in 5th column
                    {

                        // Get the selected row
                        var selectedRow = dgvCustomers.Rows[e.RowIndex];

                        // Get the customer ID from the selected row
                        string? customerId = selectedRow.Cells[0].Value.ToString();

                        // Create a new instance of the EditCustomer form
                        var editCustomer = new EditCustomer(this, customerId!);

                        // Show the Editform
                        editCustomer.ShowDialog();

                    }

                    // Perform delete action
                    else if (buttonCell.OwningColumn.Index == 6)    // Delete button is in 6th column
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
                            int idIndex = 0;
                            String idToDelete = (String)selectedRow.Cells[idIndex].Value;

                            Form? parentForm = this.FindForm();

                            try
                            {
                                await _mongoConnector.DeleteCustomer(idToDelete);

                                showMessage.ShowSuccessMessage("Customer deleted successfully!", parentForm!);

                                // Refresh the DataGridView to reflect the changes
                                RefreshCustomers();
                            }
                            catch (Exception ex)
                            {
                                showMessage.ShowErrorMessage(ex.Message, parentForm!);
                            }

                        }
                    }
                }
            }
        }

        private Color defaultForeColor;

        private void dgvCustomers_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCustomers.Rows.Count)
            {
                defaultForeColor = dgvCustomers.Rows[e.RowIndex].DefaultCellStyle.ForeColor;
                dgvCustomers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(10, 73, 156);
            }

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editBlue;
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleteRed;
            }

            if ((e.ColumnIndex == 6 && e.RowIndex >= 0) || (e.ColumnIndex == 5 && e.RowIndex >= 0))
            {
                // Change the cursor to a hand when hovering over the cell
                dgvCustomers.Cursor = Cursors.Hand;
            }
            else
            {
                dgvCustomers.Cursor = Cursors.Default;
            }

        }

        private void dgvCustomers_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCustomers.Rows.Count)
            {
                dgvCustomers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = defaultForeColor;
            }

            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.edit;
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleteGray;
            }

        }
    }
}
