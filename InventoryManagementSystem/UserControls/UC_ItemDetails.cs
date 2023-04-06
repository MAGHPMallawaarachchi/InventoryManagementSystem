using InventoryManagementSystem.DataModels;
using InventoryManagementSystem.Messages;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;
using System.Drawing.Drawing2D;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_ItemDetails : UserControl
    {
        private readonly MongoConnector _mongoConnector;
        ShowMessage showMessage = new ShowMessage();

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

        public async void UpdateContent(string part_number)
        {
            //Displaying the parameter of the part Number label 
            partNumber.Text = part_number.ToString();

            var document = await _mongoConnector.GetByPartNumber(partNumber.Text.ToString());

            //Storing the variables of the document
            //Creating Variables
            var oem_number = document.oem_number;
            var description = document.description;
            var category = document.category;
            var brand = document.brand;
            var vehicle_brand = document.vehicle_brand;
            var buying_price = document.buying_price;
            var unit_price = document.unit_price;
            var quantity = document.quantity;
            var quantity_sold = document.quantity_sold;
            var quantity_in_hand = document.quantity_in_hand;
            var supplier = document.supplier;
            var cost = document.total_cost;
            var revenue = document.total_revenue;
            var profit = document.total_profit;


            //Displaying fetched data
            lblPartNumberData.Text = part_number;
            lblOEMNumberData.Text = oem_number;
            lblDescriptionData.Text = description;
            lblCategoryData.Text = category;
            lblBrandData.Text = brand;
            lblVehicleBrandData.Text = vehicle_brand;
            lblSupplierNameData.Text = supplier;
            lblBuyingPriceData.Text = buying_price.ToString();
            lblUnitPriceData.Text = unit_price.ToString();
            lblTotalQuantityData.Text = quantity.ToString();
            lblQuantitySoldData.Text = quantity_sold.ToString();
            lblQuantityInHandData.Text = quantity_in_hand.ToString();
            lblCostData.Text = cost.ToString();
            lblRevenueData.Text = revenue.ToString();
            lblProfitData.Text = profit.ToString();

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
            lblPartNumberData.Hide();
            lblOEMNumberData.Hide();
            lblDescriptionData.Hide();
            lblCategoryData.Hide();
            lblBrandData.Hide();
            lblVehicleBrandData.Hide();
            lblSupplierNameData.Hide();
            lblBuyingPriceData.Hide();
            lblUnitPriceData.Hide();
            lblQuantityInHandData.Hide(); //quantity in hand in stock details i named it as qtyInHnd
            lblQuantitySoldData.Hide();
            lblTotalQuantityData.Hide();
            lblCostData.Hide();
            lblRevenueData.Hide();
            lblProfitData.Hide();


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
            txtCost.Visible = true;
            txtRevenue.Visible = true;
            txtProfit.Visible = true;


            // copy the old data to the text box
            txtPartNumber.Text = lblPartNumberData.Text;
            txtOEMNumber.Text = lblOEMNumberData.Text;
            txtDescription.Text = lblDescriptionData.Text;
            txtCategory.Text = lblCategoryData.Text;
            txtBrand.Text = lblBrandData.Text;
            txtVehicleBrand.Text = lblVehicleBrandData.Text;
            txtSupplier.Text = lblSupplierNameData.Text;
            txtBuyingPrice.Text = lblBuyingPriceData.Text;
            txtUnitPrice.Text = lblUnitPriceData.Text;
            txtTotalQuantity.Text = lblTotalQuantityData.Text;
            txtQuantitySold.Text = lblQuantitySoldData.Text;
            txtQuantityInHand.Text = lblQuantityInHandData.Text;
            txtCost.Text = lblCostData.Text;
            txtProfit.Text = lblProfitData.Text;
            txtRevenue.Text = lblRevenueData.Text;

            // hide the old data label
            lblPartNumberData.Visible = false;
            lblDescriptionData.Visible = false;
            lblCategoryData.Visible = false;
            lblBrandData.Visible = false;
            lblVehicleBrandData.Visible = false;
            lblSupplierNameData.Visible = false;
            lblBuyingPriceData.Visible = false;
            lblUnitPriceData.Visible = false;
            lblQuantitySoldData.Visible = false;
            lblQuantityInHandData.Visible = false;
            lblTotalQuantityData.Visible = false;
            lblCostData.Visible = false;
            lblProfitData.Visible = false;
            lblRevenueData.Visible = false;

        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("part_number", txtPartNumber.Text.ToString());
            BsonDocument updateItem = new BsonDocument
            {
                {"part_number", txtPartNumber.Text.ToString()},
                {"oem_number", txtOEMNumber.Text.ToString()},
                {"description", txtDescription.Text.ToString()},
                {"category", txtCategory.Text.ToString()},
                {"brand", txtBrand.Text.ToString()},
                {"vehicle_brand", txtVehicleBrand.Text.ToString()},
                {"supplier", txtSupplier.Text.ToString()},
                {"buying_price", Convert.ToDecimal(txtBuyingPrice.Text) },
                {"unit_price", Convert.ToDecimal(txtUnitPrice.Text) },
                {"quantity", Convert.ToInt32(txtTotalQuantity.Text) },
                {"quantity_sold", Convert.ToInt32(txtQuantitySold.Text) },
                {"quantity_in_hand", Convert.ToInt32(txtQuantityInHand.Text) },
                {"total_cost", Convert.ToDecimal(txtCost.Text) },
                {"total_profit", Convert.ToDecimal(txtProfit.Text) },
                {"total_revenue", Convert.ToDecimal(txtRevenue.Text) }
            };

            var isUpdated = await _mongoConnector.UpdateDocumentAsync("items", filter, updateItem);

            // check if the update was successful
            if (isUpdated)
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
            lblPartNumberData.Visible = true;
            lblOEMNumberData.Visible = true;
            lblDescriptionData.Visible = true;
            lblCategoryData.Visible = true;
            lblBrandData.Visible = true;
            lblVehicleBrandData.Visible = true;
            lblSupplierNameData.Visible = true;
            lblBuyingPriceData.Visible = true;
            lblUnitPriceData.Visible = true;
            lblQuantityInHandData.Visible = true; //quantity in hand in stock details i named it as qtyInHnd
            lblQuantitySoldData.Visible = true;
            lblTotalQuantityData.Visible = true;
            lblRevenueData.Visible = true;
            lblCostData.Visible = true;
            lblProfitData.Visible = true;


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
            lblQuantityInHandData.Hide();
            txtTotalQuantity.Hide();
            txtQuantitySold.Hide();
            txtQuantityInHand.Hide();
            txtRevenue.Hide();
            txtProfit.Hide();
            txtCost.Hide();

            // hide the old data label
            lblPartNumberData.Visible = true;
            lblDescriptionData.Visible = true;
            lblCategoryData.Visible = true;
            lblBrandData.Visible = true;
            lblVehicleBrandData.Visible = true;
            lblSupplierNameData.Visible = true;
            lblBuyingPriceData.Visible = true;
            lblUnitPriceData.Visible = true;
            lblQuantitySoldData.Visible = true;
            lblQuantityInHandData.Visible = true;
            lblTotalQuantityData.Visible = true;
            lblCostData.Visible = true;
            lblProfitData.Visible = true;
            lblRevenueData.Visible = true;

            UpdateContent(partNumber.Text.ToString());
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteConfirmation deleteConfirmation = new DeleteConfirmation();
            DialogResult result = deleteConfirmation.ShowDialog();

            if (result == DialogResult.OK)
            {
                Form? parentForm = this.FindForm();

                try
                {
                    await _mongoConnector.DeleteItem(partNumber.Text.ToString());

                    UC_Inventory uc = new UC_Inventory();

                    Dashboard? dashboard = this.FindForm() as Dashboard;

                    if (dashboard != null)
                    {
                        dashboard.addUserControl(uc);
                    }

                    showMessage.ShowSuccessMessage("Item deleted successfully!", parentForm!);
                }
                catch (Exception ex)
                {
                    showMessage.ShowErrorMessage(ex.Message, parentForm!);
                }
            }
            else if (result == DialogResult.Cancel || deleteConfirmation.Cancelled)
            {
                deleteConfirmation.Close();
                return;
            }

        }
    }
}
