using InventoryManagementSystem.UserControls;
using Siticone.Desktop.UI.WinForms.Suite;
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
using MongoDB.Driver;
using MongoDB.Bson;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_ItemDetails : UserControl
    {
        public UC_ItemDetails()
        {
            InitializeComponent();
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdatePanelRegion(Panel panel)
        {
            // Create a new GraphicsPath object that defines a rounded rectangle
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Set the Region property of the panel to the new GraphicsPath object
            panel.Region = new Region(path);
        }


        public void ItemsLoad()
        {


            // Disable automatic row height adjustment
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            // Create a MongoDB client and connect to the database
            var mongoClient = new MongoClient("mongodb://127.0.0.1:27017/?directConnection=true&serverSelectionTimeoutMS=2000&appName=mongosh+1.8.0");
            var database = mongoClient.GetDatabase("InventoryManagementSystem");

            // Get a reference to the collection you want to query
            var collection = database.GetCollection<BsonDocument>("items");

            // Execute the query and store the result in a variable
            var result = collection.Find(new BsonDocument()).ToList();

            // Process the result
            foreach (var document in result)
            {

                // Do something with each document
                var partNumberData = document["part_number"].AsString;
                var oemNumberData = document["oem_number"].AsString;
                var categoryData = document["category"].AsString;
                var brandData = document["brand"].AsString;
                var descriptionData = document["description"].AsInt32;
                var supplierNameData = document["supplier"].AsString;
                var supplierEmailData = document["supplier"].AsString;
                var quantity = document["quantity"].AsInt32;
                var qtySoldData = document["quantity_sold"].AsInt32;
                var qtyInHandData = quantity - qtySoldData;
                var buyingPriceData = document["buying_price"].AsDecimal128;
                var totalQtyData = qtySoldData + qtyInHandData;

                
            }

        }

        private void siticonePanel1_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(siticonePanel1);
        }

        private void siticonePanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            // Retrieve the previous page or form data from MongoDB
            //var client = new MongoClient("mongodb://127.0.0.1:27017/?directConnection=true&serverSelectionTimeoutMS=2000&appName=mongosh+1.8.0");
            //var database = mongoClient.GetDatabase("InventoryManagementSystem");
            //var collection = database.GetCollection<BsonDocument>("items");
            //var filter = Builders<BsonDocument>.Filter.Eq("page", "previous");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void partNumber_Click(object sender, EventArgs e)
        {
        }

        private void primaryDetails_Click(object sender, EventArgs e)
        {
        }

        private void itemNumber_Click(object sender, EventArgs e)
        {
        }

        private void oemumber_Click(object sender, EventArgs e)
        {
        }

        private void description_Click(object sender, EventArgs e)
        {
        }

        private void category_Click(object sender, EventArgs e)
        {
        }

        private void brand_Click(object sender, EventArgs e)
        {
        }

        private void supplierDetails_Click(object sender, EventArgs e)
        {
        }

        private void supplierName_Click(object sender, EventArgs e)
        {
        }

        private void supplierEmail_Click(object sender, EventArgs e)
        {
        }

        private void priceDetails_Click(object sender, EventArgs e)
        {
        }

        private void buyingPrice_Click(object sender, EventArgs e)
        {
        }

        private void qtySold_Click(object sender, EventArgs e)
        {

        }
    }
}
