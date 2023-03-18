using InventoryManagementSystem.Messages;
using InventoryManagementSystem.UserControls;
using MongoDB.Bson;
using System.Configuration;

namespace InventoryManagementSystem
{
    public partial class AddItem : Form
    {
        private readonly MongoConnector _mongoConnector;
        private readonly UC_Inventory _ucInventory;

        public AddItem(UC_Inventory ucInventory)
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");

            _ucInventory = ucInventory;
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
            decimal buyingPrice = Convert.ToDecimal(txtBuyingPrice.Text);
            decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            decimal totalCost = 0;
            decimal totalRevenue = 0;
            decimal totalProfit = totalRevenue - totalCost;

            BsonDocument newItem = new BsonDocument
            {
                {"part_number", txtPartNumber.Text.ToString()},
                {"oem_number", txtOEMNumber.Text.ToString()},
                {"description", txtDescription.Text.ToString()},
                {"category", txtCategory.Text.ToString()},
                {"brand", txtBrand.Text.ToString()},
                {"vehicle_brand", txtVehicleBrand.Text.ToString()},
                {"supplier", txtSupplier.Text.ToString()},
                {"buying_price", buyingPrice },
                {"unit_price", unitPrice },
                {"quantity", Convert.ToInt32(txtQuantity.Text) },
                {"quantity_sold", 0 },
                {"quantity_in_hand", Convert.ToInt32(txtQuantity.Text) },
                {"total_cost", totalCost },
                {"total_profit", totalProfit },
                {"total_revenue", totalRevenue }
            };

            try
            {
                await _mongoConnector.InsertDocumentAsync("items", newItem);

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

                _ucInventory.RefreshInventory();

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

    }
}
