using dotenv.net;
using MongoDB.Bson;
using MongoDB.Driver;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_ItemDetails : UserControl
    {
        public UC_ItemDetails()
        {
            InitializeComponent();
        }

        public void UpdateContent(string part_number)
        {
            //Displaying the parameter of the part Number label 
            partNumber.Text = part_number.ToString();

            // Create a MongoDB client and connect to the database
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["ConnectionString"]);

            var database = mongoClient.GetDatabase("InventoryManagementSystem");

            // Get a reference to the collection you want to query
            var collection = database.GetCollection<BsonDocument>("items");

            // Define the query filter . representing the query
            var filter = Builders<BsonDocument>.Filter.Eq("part_number", part_number);

            //Storing the variable of the filtered document 
            var document = collection.Find(filter).FirstOrDefault();

            //Storing the variables of the document
            //Creating Variables
            var oem_number = document["oem_number"].AsString;
            var description = document["description"].AsString;
            var category = document["category"].AsString;
            var brand = document["brand"].AsString;
            var buying_price = document["buying_price"].AsDecimal128;
            var quantity = document["quantity"].AsInt32;
            var quantity_sold = document["quantity_sold"].AsInt32;
            var supplier = document["supplier"].AsString;
            int quantity_in_hand = quantity - quantity_sold;


            //Displaying fetched data
            partNumberData.Text = part_number.ToString();
            oemNumberData.Text = oem_number.ToString();
            descriptionData.Text = description.ToString();
            categoryData.Text = category.ToString();
            brandData.Text = brand.ToString();
            supplierNameData.Text = supplier.ToString();
            buyingPriceData.Text = buying_price.ToString();
            qtyInHandData.Text = quantity_in_hand.ToString();
            totalQtyData.Text = quantity.ToString();
            qtySoldData.Text = quantity_sold.ToString();
            
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

        private void siticonePanel1_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(siticonePanel1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UC_Inventory uc = new UC_Inventory();

            Dashboard? dashboard = this.FindForm() as Dashboard;

            if (dashboard != null)
            {
                dashboard.addUserControl(uc);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            partNumberData.Hide();
            oemNumberData.Hide();
            descriptionData.Hide();
            categoryData.Hide();
            brandData.Hide();
            supplierNameData.Hide();
            buyingPriceData.Hide();
            qtyInHandData.Hide();
            totalQtyData.Hide();
            qtySoldData.Hide();
            
        }

    }
}
