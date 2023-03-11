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
using static MongoDB.Driver.WriteConcern;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            var unit_price = document["unit_price"].AsDecimal128;
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
            unitPriceData.Text = unit_price.ToString();
            totalQtyData.Text = quantity.ToString();
            qtySoldData.Text = quantity_sold.ToString();
            qtyInHndData.Text = quantity_in_hand.ToString();

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
            // set the update button control to visible
            btnUpdate.Visible = true;
            btnDiscard.Visible = true;
            btnEdit.Hide();
            btnBack.Hide();

            //Hiding the Previous data
            partNumberData.Hide();
            oemNumberData.Hide();
            descriptionData.Hide();
            categoryData.Hide();
            brandData.Hide();
            supplierNameData.Hide();
            buyingPriceData.Hide();
            unitPriceData.Hide();
            qtyInHndData.Hide(); //quantity in hand in stock details i named it as qtyInHnd
            qtySoldData.Hide();
            totalQtyData.Hide();
            supplierEmailData.Hide();


            // make the text box visible
            part_numberText.Visible = true;
            oemNumberText.Visible = true;
            descriptionText.Visible = true;
            categoryText.Visible = true;
            brandText.Visible = true;
            supplierNameText.Visible = true;
            supplierEmailText.Visible = true;
            buyingPriceText.Visible = true;
            unitPriceText.Visible = true;
            qtyInHndData.Visible = true;
            totalQtyText.Visible = true;
            qtySoldText.Visible = true;
            qtyInHndText.Visible = true;
            supplierEmailText.Visible = true;


            // copy the old data to the text box
            part_numberText.Text = partNumberData.Text;
            oemNumberText.Text = oemNumberData.Text;
            descriptionText.Text = descriptionData.Text;
            categoryText.Text = categoryData.Text;
            brandText.Text = brandData.Text;
            supplierNameText.Text = supplierNameData.Text;
            supplierEmailText.Text = supplierEmailData.Text;
            buyingPriceText.Text = buyingPriceData.Text;
            unitPriceText.Text = unitPriceData.Text;
            totalQtyText.Text = totalQtyData.Text;
            qtySoldText.Text = qtySoldData.Text;
            qtyInHndText.Text = qtyInHndData.Text;

            // hide the old data label
            partNumberData.Visible = false;
            descriptionData.Visible = false;
            categoryData.Visible = false;
            brandData.Visible = false;
            supplierNameData.Visible = false;
            supplierEmailData.Visible = false;
            buyingPriceData.Visible = false;
            unitPriceData.Visible = false;
            qtySoldData.Visible = false;
            qtyInHndData.Visible = false;
            totalQtyData.Visible = false;

        }

        private void updateBtn_Click(object sender, EventArgs e)

        {
            // retrieve the new value from the text box
            string newValue = part_numberText.Text;

            // create a new MongoDB client object
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["ConnectionString"]);

            var database = mongoClient.GetDatabase("InventoryManagementSystem");

            // Get a reference to the collection you want to query
            var collection = database.GetCollection<BsonDocument>("items");

            // Define the query filter . representing the query
            var filter = Builders<BsonDocument>.Filter.Eq("part_number", "part_numberText.Text");
            UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set("part_number", newValue);

            // execute the update operation
            UpdateResult result = collection.UpdateOne(filter, update);

            // check if the update was successful
            if (result.ModifiedCount > 0)
            {
                // retrieve the updated document or documents from the database
                List<BsonDocument> documents = collection.Find(filter).ToList();

                // display the updated values
                foreach (BsonDocument document in documents)
                {
                    string updatedValue = document["part_number"].ToString();
                    part_numberText.Text = updatedValue;
                }
            }
            else
            {
                // display an error message if the update failed
                part_numberText.Text = "Update failed.";
            }

        }

        private void UC_ItemDetails_Load(object sender, EventArgs e)
        {
            // set the update button control to not visible
            btnUpdate.Visible = false;
            btnDiscard.Visible = false;
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {

            btnUpdate.Hide();
            btnDiscard.Hide();
            btnEdit.Visible = true;
            btnBack.Visible = true;

            //making the Previous data visible
            partNumberData.Visible = true;
            oemNumberData.Visible = true;
            descriptionData.Visible = true;
            categoryData.Visible = true;
            brandData.Visible = true;
            supplierNameData.Visible = true;
            buyingPriceData.Visible = true;
            unitPriceData.Visible = true;
            qtyInHndData.Visible = true; //quantity in hand in stock details i named it as qtyInHnd
            qtySoldData.Visible = true;
            totalQtyData.Visible = true;
            supplierEmailData.Visible = true;


            // hide the text boxes
            part_numberText.Hide();
            oemNumberText.Hide();
            descriptionText.Hide();
            categoryText.Hide();
            brandText.Hide();
            supplierNameText.Hide();
            supplierEmailText.Hide();
            buyingPriceText.Hide();
            unitPriceText.Hide();
            qtyInHndData.Hide();
            totalQtyText.Hide();
            qtySoldText.Hide();
            qtyInHndText.Hide();
            supplierEmailText.Hide();

            // hide the old data label
            partNumberData.Visible = true;
            descriptionData.Visible = true;
            categoryData.Visible = true;
            brandData.Visible = true;
            supplierNameData.Visible = true;
            supplierEmailData.Visible = true;
            buyingPriceData.Visible = true;
            unitPriceData.Visible = true;
            qtySoldData.Visible = true;
            qtyInHndData.Visible = true;
            totalQtyData.Visible = true;
        }
    }
}
