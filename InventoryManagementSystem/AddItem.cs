using InventoryManagementSystem.Messages;
using InventoryManagementSystem.UserControls;
using MongoDB.Bson;
using Siticone.Desktop.UI.WinForms;
using System.Configuration;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

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
            lblSuccess.Visible = false;
            HideErrorLabels();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
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

                    /*var addItemSuccessForm = new AddItemSuccess();
                    addItemSuccessForm.Owner = this;
                    addItemSuccessForm.TopMost = true;
                    addItemSuccessForm.ShowDialog();*/

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

                    lblSuccess.Visible = true;
                    Timer timer = new Timer();
                    timer.Interval = 5000; // 5000ms = 5s
                    timer.Tick += (s, e) =>
                    {
                        lblSuccess.Visible = false;
                        timer.Stop();
                    };
                    timer.Start();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the item to the database: {ex.Message}");
                }
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            isValid = ValidateField(txtPartNumber, lblPartNumberError, "Please enter a part number.") && isValid;
            isValid = ValidateField(txtOEMNumber, lblOEMNumberError, "Please enter an OEM number.") && isValid;
            isValid = ValidateField(txtDescription, lblDescriptionError, "Please enter a description.") && isValid;
            isValid = ValidateField(txtCategory, lblCategoryError, "Please enter a category.") && isValid;
            isValid = ValidateField(txtBrand, lblBrandError, "Please enter a brand.") && isValid;
            isValid = ValidateField(txtVehicleBrand, lblVehicleBrandError, "Please enter a vehicle brand.") && isValid;
            isValid = ValidateField(txtSupplier, lblSupplierError, "Please enter the vehicle brand.") && isValid;
            isValid = ValidateDecimalField(txtBuyingPrice, lblBuyingPriceError, "Please enter a valid buying price.") && isValid;
            isValid = ValidateDecimalField(txtUnitPrice, lblUnitPriceError, "Please enter a valid unit price.") && isValid;
            isValid = ValidateIntegerField(txtQuantity, lblQuantityError, "Please enter a valid quantity.") && isValid;

            return isValid;
        }

        private bool ValidateField(SiticoneTextBox textBox, Label errorLabel, string errorMessage)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                isValid = false;
                errorLabel.Text = errorMessage;
                errorLabel.Visible = true;
                textBox.BorderColor = ColorTranslator.FromHtml("#DA3E33");
            }
            else
            {
                errorLabel.Visible = false;
            }

            return isValid;
        }

        private bool ValidateDecimalField(SiticoneNumericUpDown textBox, Label errorLabel, string errorMessage)
        {
            bool isValid = true;

            if (!decimal.TryParse(textBox.Text, out decimal value) || value <= 0)
            {
                isValid = false;
                errorLabel.Text = errorMessage;
                errorLabel.Visible = true;
                textBox.BorderColor = ColorTranslator.FromHtml("#DA3E33");
            }
            else
            {
                errorLabel.Visible = false;
            }

            return isValid;
        }

        private bool ValidateIntegerField(SiticoneNumericUpDown textBox, Label errorLabel, string errorMessage)
        {
            bool isValid = true;

            if (!int.TryParse(textBox.Text, out int value) || value <= 0)
            {
                isValid = false;
                errorLabel.Text = errorMessage;
                errorLabel.Visible = true;
                textBox.BorderColor = ColorTranslator.FromHtml("#DA3E33");
            }
            else
            {
                errorLabel.Visible = false;
            }

            return isValid;
        }

        private void HideErrorLabels()
        {
            lblPartNumberError.Visible = false;
            lblOEMNumberError.Visible = false;
            lblDescriptionError.Visible = false;
            lblCategoryError.Visible = false;
            lblBrandError.Visible = false;
            lblVehicleBrandError.Visible = false;
            lblBuyingPriceError.Visible = false;
            lblUnitPriceError.Visible = false;
            lblQuantityError.Visible = false;
            lblSupplierError.Visible = false;
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
            lblPartNumberError.Visible = false;
            txtPartNumber.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtOEMNumber_TextChanged(object sender, EventArgs e)
        {
            lblOEMNumberError.Visible = false;
            txtOEMNumber.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescriptionError.Visible = false;
            txtDescription.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            lblCategoryError.Visible = false;
            txtCategory.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            lblBrandError.Visible = false;
            txtBrand.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtVehicleBrand_TextChanged(object sender, EventArgs e)
        {
            lblVehicleBrandError.Visible = false;
            txtVehicleBrand.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            lblSupplierError.Visible = false;
            txtSupplier.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtBuyingPrice_ValueChanged(object sender, EventArgs e)
        {
            lblBuyingPriceError.Visible = false;
            txtBuyingPrice.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            lblUnitPriceError.Visible = false;
            txtUnitPrice.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            lblQuantityError.Visible = false;
            txtQuantity.BorderColor = ColorTranslator.FromHtml("#D0D5DD");
        }
    }
}
