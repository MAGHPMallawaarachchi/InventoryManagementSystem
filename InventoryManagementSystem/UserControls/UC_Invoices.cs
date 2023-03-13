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
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_Invoices : UserControl
    {
        private readonly MongoConnector _mongoConnector;
        private decimal total = 0;

        public UC_Invoices()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void UC_Invoices_Load(object sender, EventArgs e)
        {
            UpdatePanelRegion(Panel2);
            UpdatePanelRegion(Panel1);
            UpdatePanelRegion(Panel3);


            dgvItemsLoad();
            ComboBoxLoad();

            lblMessrsData.Text = "-- Name --";
            lblAddressData.Text = "-- Address --";
            lblCityData.Text = "-- City --";
            lblPhoneNoData.Text = "-- Phone No --";

            lblInvoiceNoData.Text = "KAP-10000";
            lblInvoiceNo.Text = "KAP-10000";
            lblDateData.Text = DateTime.Today.ToShortDateString();
            lblTimeData.Text = DateTime.Now.ToString("hh:mm:ss tt");


        }

        private async void dgvItemsLoad()
        {
            //get all the items from the collection items
            var documents = await _mongoConnector.GetAllItems();

            // Create a list of part number strings
            var partNumberList = new List<string> { "-- Part Number --" };
            foreach (var document in documents)
            {
                var partNumber = document.part_number;
                if (partNumber != null)
                    partNumberList.Add(partNumber.ToString());
            }

            no.ReadOnly = true;
            no.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            no.Width = 20;

            part_no.AutoComplete = true;
            part_no.MaxDropDownItems = 10;
            part_no.FlatStyle = FlatStyle.Flat;
            part_no.DataSource = partNumberList;
            part_no.Width = 300;

            brand.Width = 300;
            description.Width = 600;

            qty.ValueType = typeof(int);
            qty.Width = 50;

            unit_price.ValueType = typeof(decimal);

            amount.ValueType = typeof(decimal);

            AddRow();

        }

        private void AddRow()
        {
            // Set the row template of the DataGridView control
            dgvItems.Rows.Add();

            // Get the index of the last row
            int rowIndex = dgvItems.Rows.Count - 1;

            DataGridViewRow templateRow = dgvItems.Rows[rowIndex];
            templateRow.Cells[0].Value = rowIndex + 1;
            templateRow.Cells[1].Value = "-- Part Number --";
            templateRow.Cells[2].Value = "-- Brand --";
            templateRow.Cells[3].Value = "-- Description --";
            templateRow.Cells[4].Value = 0;
            templateRow.Cells[5].Value = 0.00;
            templateRow.Cells[6].Value = 0.00;
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

        private void Panel1_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(Panel1);
        }

        private void Panel2_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(Panel2);
        }

        private void Panel3_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelRegion(Panel3);
        }

        public async void ComboBoxLoad()
        {
            // Add the placeholder item to the ComboBox
            cbCustomerID.Items.Add("-- Select Customer ID --");
            cbCustomerID.SelectedIndex = 0;
            cbCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;

            var customers = await _mongoConnector.GetAllCustomers();

            foreach (var customer in customers)
            {
                cbCustomerID.Items.Add(customer.customer_id);
            }
        }

        private async void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerID.SelectedIndex != 0)
            {
                string selectedCustomer = cbCustomerID.Text;

                var document = await _mongoConnector.GetByCustomerID(selectedCustomer);

                if (document != null)
                {
                    lblMessrsData.Text = document.name;
                    lblAddressData.Text = document.address;
                    lblCityData.Text = document.city;
                    lblPhoneNoData.Text = document.phone_no;
                }
            }
        }

        private async void dgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvItems.Columns["part_no"].Index)
            {
                var selectedPartNumber = dgvItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedPartNumber) && selectedPartNumber != "-- Part Number --")
                {
                    var document = await _mongoConnector.GetByPartNumber(selectedPartNumber);

                    if (document != null)
                    {
                        dgvItems.Rows[e.RowIndex].Cells["brand"].Value = document.brand;
                        dgvItems.Rows[e.RowIndex].Cells["description"].Value = document.description;
                        dgvItems.Rows[e.RowIndex].Cells["unit_price"].Value = document.unit_price;
                    }
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvItems.Columns["qty"].Index)
            {
                int qtyValue = 0;
                decimal amount = 0;

                if (int.TryParse(dgvItems.Rows[e.RowIndex].Cells["qty"].Value?.ToString(), out qtyValue))
                {
                    decimal qtyDecimalValue = new decimal(qtyValue);
                    decimal unitPrice = Convert.ToDecimal(dgvItems.Rows[e.RowIndex].Cells["unit_price"].Value);
                    amount = unitPrice * qtyDecimalValue;
                }
                dgvItems.Rows[e.RowIndex].Cells["amount"].Value = amount;
            }

            if (dgvItems.Rows.Count > 0)
            {
                DataGridViewRow lastRow = dgvItems.Rows[dgvItems.Rows.Count - 1];
                decimal amount = Convert.ToDecimal(lastRow.Cells["amount"].Value);
                total += amount;

                lblTotalData.Text = (total / 2).ToString();
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();
            dgvItemsLoad();
            cbCustomerID.SelectedIndex = 0;

            lblMessrsData.Text = "-- Name --";
            lblAddressData.Text = "-- Address --";
            lblCityData.Text = "-- City --";
            lblPhoneNoData.Text = "-- Phone No --";
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            // Create a MongoDB client and connect to the database
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["ConnectionString"]);
            var database = mongoClient.GetDatabase("InventoryManagementSystem");
            var collection = database.GetCollection<BsonDocument>("items");

            // create a new invoice document
            var invoice = new BsonDocument
            {
                { "prefix", "KAP-" },
                { "sequence", 10000 },
                { "date", DateTime.Today.ToShortDateString()},
                { "time", DateTime.Now.ToString("hh:mm:ss tt") },
                { "customer_id", cbCustomerID.Text},
                { "items", new BsonArray() } // initialize an empty array
            };

            // iterate through the rows of the DataGridView and add each row as a new BsonDocument to the "items" array
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                string partNumber = row.Cells["part_no"].Value.ToString();
                int quantity = int.Parse(row.Cells["qty"].Value.ToString());
                decimal amount = decimal.Parse(row.Cells["amount"].Value.ToString());

                var filter = Builders<BsonDocument>.Filter.Eq("part_number", partNumber);
                var document = collection.Find(filter).FirstOrDefault();

                decimal buyingPrice = document["buying_price"].ToDecimal();

                var item = new BsonDocument
                {
                    { "part_number", partNumber },
                    { "quantity", quantity },
                    { "amount", amount }
                };

                invoice["items"].AsBsonArray.Add(item);
            }
        }

    }
}
