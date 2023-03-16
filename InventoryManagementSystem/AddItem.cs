using InventoryManagementSystem.DataModels;
using InventoryManagementSystem.Messages;
using System.Configuration;

namespace InventoryManagementSystem
{
    public partial class AddItem : Form
    {
        private readonly MongoConnector _mongoConnector;

        public AddItem()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {

            Item item = new Item
            {
                part_number = txtPartNumber.Text,
                oem_number = txtOEMNumber.Text,
                description = txtDescription.Text,
                category = txtCategory.Text,
                brand = txtBrand.Text,
                vehicle_brand = txtVehicleBrand.Text,
                supplier = txtSupplier.Text,
                buying_price = Convert.ToDecimal(txtBuyingPrice.Text),
                unit_price = Convert.ToDecimal(txtUnitPrice.Text),
                quantity = Convert.ToInt32(txtQuantity.Text),
                quantity_sold = 0,
                quantity_in_hand = Convert.ToInt32(txtQuantity.Text),
                total_cost = 0,
                total_profit = 0,
                total_revenue = 0,
            };

            try
            {
                await _mongoConnector.Insert<Item>("items", item);

                var addItemSuccessForm = new AddItemSuccess();
                addItemSuccessForm.Owner = this;
                addItemSuccessForm.TopMost = true;
                addItemSuccessForm.ShowDialog();

                // Empty the text boxes
                txtPartNumber.Text = "";
                txtOEMNumber.Text = "";
                txtDescription.Text = "";
                txtCategory.Text = "";
                txtBrand.Text = "";
                txtVehicleBrand.Text = "";
                txtBuyingPrice.Value = 0;
                txtUnitPrice.Value = 0;
                txtQuantity.Value = 0;
                txtSupplier.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the item to the database: {ex.Message}");
            }
        }

        private void txtPartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtOEMNumber.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtSupplier.Focus();
            }
        }

        private void txtOEMNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtDescription.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtPartNumber.Focus();
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtCategory.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtOEMNumber.Focus();
            }
        }

        private void txtCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtBrand.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtDescription.Focus();
            }
        }

        private void txtBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtVehicleBrand.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtCategory.Focus();
            }
        }

        private void txtVehicleBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtBuyingPrice.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtBrand.Focus();
            }
        }

        private void txtBuyingPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtUnitPrice.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtVehicleBrand.Focus();
            }
        }

        private void txtUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtQuantity.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtBuyingPrice.Focus();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtSupplier.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtUnitPrice.Focus();
            }
        }

        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtPartNumber.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txtQuantity.Focus();
            }
        }

        private void txtPartNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
