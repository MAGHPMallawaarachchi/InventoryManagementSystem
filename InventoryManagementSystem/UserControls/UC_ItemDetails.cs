using InventoryManagementSystem.DataModels;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;
using System.Drawing.Drawing2D;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_ItemDetails : UserControl
    {
        private readonly MongoConnector _mongoConnector;
        public UC_ItemDetails()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void UC_ItemDetails_Load(object sender, EventArgs e)
        {
            // set the update button control to not visible
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
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
            var vehicle_brand = document["vehicle_brand"].AsString;
            var buying_price = document["buying_price"].AsDecimal128;
            var unit_price = document["unit_price"].AsDecimal128;
            var quantity = document["quantity"].AsInt32;
            var quantity_sold = document["quantity_sold"].AsInt32;
            var supplier = document["supplier"].AsString;
            int quantity_in_hand = quantity - quantity_sold;

            //Displaying fetched data
            partNumberData.Text = part_number;
            oemNumberData.Text = oem_number;
            descriptionData.Text = description;
            categoryData.Text = category;
            brandData.Text = brand;
            lblVehicleBrandData.Text = vehicle_brand;
            supplierNameData.Text = supplier;
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
            btnCancel.Visible = true;
            btnEdit.Hide();
            btnBack.Hide();

            //Hiding the Previous data
            partNumberData.Hide();
            oemNumberData.Hide();
            descriptionData.Hide();
            categoryData.Hide();
            brandData.Hide();
            lblVehicleBrandData.Hide();
            supplierNameData.Hide();
            buyingPriceData.Hide();
            unitPriceData.Hide();
            qtyInHndData.Hide(); //quantity in hand in stock details i named it as qtyInHnd
            qtySoldData.Hide();
            totalQtyData.Hide();


            // make the text box visible
            txtPartNumber.Visible = true;
            txtOEMNumber.Visible = true;
            txtDescription.Visible = true;
            txtCategory.Visible = true;
            txtBrand.Visible = true;
            txtVehicleBrand.Visible = true;
            txtSupplier.Visible = true;
            txtBuyingPrice.Visible = true;
            txtUnitPrice.Visible = true;
            txtQuantityInHand.Visible = true;
            txtTotalQuantity.Visible = true;
            txtQuantitySold.Visible = true;


            // copy the old data to the text box
            txtPartNumber.Text = partNumberData.Text;
            txtOEMNumber.Text = oemNumberData.Text;
            txtDescription.Text = descriptionData.Text;
            txtCategory.Text = categoryData.Text;
            txtBrand.Text = brandData.Text;
            txtVehicleBrand.Text = lblVehicleBrandData.Text;
            txtSupplier.Text = supplierNameData.Text;
            txtBuyingPrice.Text = buyingPriceData.Text;
            txtUnitPrice.Text = unitPriceData.Text;
            txtTotalQuantity.Text = totalQtyData.Text;
            txtQuantitySold.Text = qtySoldData.Text;
            txtQuantityInHand.Text = qtyInHndData.Text;

            // hide the old data label
            partNumberData.Visible = false;
            descriptionData.Visible = false;
            categoryData.Visible = false;
            brandData.Visible = false;
            lblVehicleBrandData.Visible = false;
            supplierNameData.Visible = false;
            buyingPriceData.Visible = false;
            unitPriceData.Visible = false;
            qtySoldData.Visible = false;
            qtyInHndData.Visible = false;
            totalQtyData.Visible = false;

        }

        private async void updateBtn_Click(object sender, EventArgs e)

        {
            var updatedItem = new Item
            {
                part_number = txtPartNumber.Text.ToString(),
                oem_number = txtOEMNumber.Text.ToString(),
                description = txtDescription.Text.ToString(),
                category = txtCategory.Text.ToString(),
                brand = txtBrand.Text.ToString(),
                vehicle_brand = txtVehicleBrand.Text.ToString(),
                buying_price = Convert.ToDecimal(txtBuyingPrice.Text),
                unit_price = Convert.ToDecimal(txtUnitPrice.Text),
                quantity = Convert.ToInt32(txtTotalQuantity.Text),
                quantity_sold = Convert.ToInt32(txtQuantitySold.Text),
                supplier = txtSupplier.Text.ToString()
            };

            var result = await _mongoConnector.UpdateItem<Item>(txtPartNumber.Text.ToString(), updatedItem);

            // check if the update was successful
            if (result)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                // display an error message if the update failed
                txtPartNumber.Text = "Update failed.";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            btnCancel.Hide();
            btnEdit.Visible = true;
            btnBack.Visible = true;

            //making the Previous data visible
            partNumberData.Visible = true;
            oemNumberData.Visible = true;
            descriptionData.Visible = true;
            categoryData.Visible = true;
            brandData.Visible = true;
            lblVehicleBrandData.Visible = true;
            supplierNameData.Visible = true;
            buyingPriceData.Visible = true;
            unitPriceData.Visible = true;
            qtyInHndData.Visible = true; //quantity in hand in stock details i named it as qtyInHnd
            qtySoldData.Visible = true;
            totalQtyData.Visible = true;


            // hide the text boxes
            txtPartNumber.Hide();
            txtOEMNumber.Hide();
            txtDescription.Hide();
            txtCategory.Hide();
            txtBrand.Hide();
            txtVehicleBrand.Hide();
            txtSupplier.Hide();
            txtBuyingPrice.Hide();
            txtUnitPrice.Hide();
            qtyInHndData.Hide();
            txtTotalQuantity.Hide();
            txtQuantitySold.Hide();
            txtQuantityInHand.Hide();

            // hide the old data label
            partNumberData.Visible = true;
            descriptionData.Visible = true;
            categoryData.Visible = true;
            brandData.Visible = true;
            lblVehicleBrandData.Visible = true;
            supplierNameData.Visible = true;
            buyingPriceData.Visible = true;
            unitPriceData.Visible = true;
            qtySoldData.Visible = true;
            qtyInHndData.Visible = true;
            totalQtyData.Visible = true;

            UpdateContent(partNumber.Text.ToString());
        }
    }
}
