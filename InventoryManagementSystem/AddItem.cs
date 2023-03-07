using ImageResizer.Plugins.Basic;
using InventoryManagementSystem.Messages;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            string connectionString = "mongodb://127.0.0.1:27017/?directConnection=true&serverSelectionTimeoutMS=2000&appName=mongosh+1.8.0";
            string databaseName = "InventoryManagementSystem";
            string collectionName = "items";

            // Get the MongoDB client
            MongoClient client = new MongoClient(connectionString);

            // Get the database and collection objects
            IMongoDatabase db = client.GetDatabase(databaseName);
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>(collectionName);

            var item = new BsonDocument {
                { "part_number", txtPartNumber.Text },
                { "oem_number", txtOEMNumber.Text },
                { "description", txtDescription.Text },
                { "category", txtCategory.Text },
                { "brand", txtBrand.Text },
                { "buying_price", txtBuyingPrice.Value },
                { "unit_price", txtUnitPrice.Value },
                { "quantity", txtQuantity.Value},
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

        private void AddItemSuccess_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
