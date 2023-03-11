using dotenv.net;
using ImageResizer.Plugins.Basic;
using InventoryManagementSystem.Messages;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string collectionName = "items";

            // Get the MongoDB client
            MongoClient client = new MongoClient(ConfigurationManager.AppSettings["ConnectionString"]);

            // Get the database and collection objects
            IMongoDatabase db = client.GetDatabase("InventoryManagementSystem");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(collectionName);

            var item = new BsonDocument {
                { "part_number", txtPartNumber.Text },
                { "oem_number", txtOEMNumber.Text },
                { "description", txtDescription.Text },
                { "category", txtCategory.Text },
                { "brand", txtBrand.Text },
                { "vehicle_brand", txtVehicleBrand.Text },
                { "buying_price", txtBuyingPrice.Value },
                { "unit_price", txtUnitPrice.Value },
                { "quantity", Convert.ToInt32(txtQuantity.Value) },
                { "quantity_sold", 0 },
                { "supplier", txtSupplier.Text },
            };

            try
            {
                collection.InsertOne(item);

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
