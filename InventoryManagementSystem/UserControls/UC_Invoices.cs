using InventoryManagementSystem.DataModels;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;
using System.Drawing.Drawing2D;


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

        private async void UC_Invoices_Load(object sender, EventArgs e)
        {
            lblRowsError.Visible = false;
            lblCustomerError.Visible = false;

            UpdatePanelRegion(Panel2);
            UpdatePanelRegion(Panel1);
            UpdatePanelRegion(Panel3);


            dgvItemsLoad();
            ComboBoxLoad();

            lblMessrsData.Text = "-- Name --";
            lblAddressData.Text = "-- Address --";
            lblCityData.Text = "-- City --";
            lblPhoneNoData.Text = "-- Phone No --";

            int InvoiceNo = 10000;

            // Check if the invoices collection is empty
            var invoicesCollection = _mongoConnector.GetCollection<Invoice>("invoices");
            long count = invoicesCollection.CountDocuments(FilterDefinition<Invoice>.Empty);

            if (count == 0)
            {
                InvoiceNo = 10000;
            }
            else
            {
                InvoiceNo = await _mongoConnector.GetLastInvoice() + 1;
            }

            lblInvoiceNoData.Text = "KAP-" + InvoiceNo;
            lblInvoiceNo.Text = "KAP-" + InvoiceNo;
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

            brand.Width = 200;
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
                lblCustomerError.Visible = false;

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
                    lblRowsError.Visible = false;

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

                lblTotalData.Text = (total / 2).ToString("N2");
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void Clear()
        {
            dgvItems.Rows.Clear();
            dgvItemsLoad();
            cbCustomerID.SelectedIndex = 0;

            int InvoiceNo = await _mongoConnector.GetLastInvoice() + 1;

            lblInvoiceNoData.Text = "KAP-" + InvoiceNo;
            lblInvoiceNo.Text = "KAP-" + InvoiceNo;
            lblDateData.Text = DateTime.Today.ToShortDateString();
            lblTimeData.Text = DateTime.Now.ToString("hh:mm:ss tt");

            lblMessrsData.Text = "-- Name --";
            lblAddressData.Text = "-- Address --";
            lblCityData.Text = "-- City --";
            lblPhoneNoData.Text = "-- Phone No --";
        }

        private async void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (cbCustomerID.SelectedIndex == 0)
            {
                lblCustomerError.Text = "Please enter the Customer ID!";
                lblCustomerError.Visible = true;
            }
            else
            {
                lblRowsError.Visible = false;

                var mongoClient = new MongoClient(ConfigurationManager.AppSettings["ConnectionString"]);
                var database = mongoClient.GetDatabase("InventoryManagementSystem");
                var collection = database.GetCollection<BsonDocument>("invoices");

                int InvoiceNo = 10000;

                // Check if the invoices collection is empty
                var invoicesCollection = _mongoConnector.GetCollection<Invoice>("invoices");
                long count = invoicesCollection.CountDocuments(FilterDefinition<Invoice>.Empty);

                if (count == 0)
                {
                    InvoiceNo = 10000;
                }
                else
                {
                    InvoiceNo = await _mongoConnector.GetLastInvoice() + 1;
                }

                decimal totalProfit = 0;
                decimal totalCost = 0;
                decimal totalRevenue = 0;

                var invoiceItems = new List<BsonDocument>();
                List<InvoiceItem> items = new List<InvoiceItem>();

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    string? partNumber = row.Cells["part_no"].Value?.ToString();

                    if (partNumber == "-- Part Number --" || partNumber == null)
                    {
                        continue;
                    }
                    else
                    {
                        int quantity = Convert.ToInt32(row.Cells["qty"].Value);
                        decimal amount = Convert.ToDecimal(row.Cells["amount"].Value);

                        decimal DecimalQty = Convert.ToDecimal(quantity);

                        var document = await _mongoConnector.GetByPartNumber(partNumber);

                        decimal cost = (document?.buying_price ?? 0) * DecimalQty;
                        decimal profit = amount - cost;

                        totalProfit += profit;
                        totalCost += cost;
                        totalRevenue += amount;

                        var invoiceItem = new BsonDocument
                        {
                            { "part_number", partNumber },
                            { "quantity", quantity },
                            { "revenue", amount },
                            { "cost", cost },
                            { "profit", profit }
                        };
                        invoiceItems.Add(invoiceItem);

                        items.Add(new InvoiceItem
                        {
                            part_number = partNumber,
                            quantity = quantity,
                            revenue = amount,
                            cost = cost,
                            profit = profit
                        });

                        decimal updateTotalCost = (decimal)(document.total_cost + (DecimalQty * document.buying_price))!;
                        decimal updateTotalRevenue = (decimal)(document.total_revenue + (DecimalQty * document.unit_price))!;
                        decimal updateTotalProfit = updateTotalRevenue - updateTotalCost;
                        int updateQuantitySold = Convert.ToInt32(document.quantity_sold + quantity);
                        int updateQuantityInHand = Convert.ToInt32(document.quantity_in_hand - quantity);

                        var updateDoc = new BsonDocument
                        {
                            { "total_cost", BsonDecimal128.Create(updateTotalCost) },
                            { "total_revenue", BsonDecimal128.Create(updateTotalRevenue) },
                            { "total_profit", BsonDecimal128.Create(updateTotalProfit) },
                            { "quantity_sold", BsonInt32.Create(updateQuantitySold) },
                            { "quantity_in_hand", BsonInt32.Create(updateQuantityInHand) }
                        };

                        var collectionNew = _mongoConnector.GetCollection<Item>("items");
                        var filter = Builders<Item>.Filter.Eq("_id", document.Id);

                        await collectionNew.UpdateOneAsync(filter, new BsonDocument("$set", updateDoc));
                    }
                }

                bool hasEmptyRows = false;
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    string? partNo = row.Cells["part_no"].Value?.ToString();
                    if (string.IsNullOrEmpty(partNo) || partNo == "-- Part Number --")
                    {
                        hasEmptyRows = true;
                        break;
                    }
                }

                if (hasEmptyRows)
                {
                    lblRowsError.Text = "The rows are empty!";
                    lblRowsError.Visible = true;
                }

                else
                {
                    // create an instance of the PdfGenerator class
                    PdfGenerator pdfGenerator = new PdfGenerator();

                    var newInvoice = new BsonDocument
                    {
                        { "prefix", "KAP-" },
                        { "sequence", InvoiceNo },
                        { "date", DateTime.Today },
                        { "time", DateTime.Now.ToString("hh:mm:ss tt") },
                        { "customer_id", cbCustomerID.Text },
                        { "items", new BsonArray(invoiceItems) },
                        { "total_profit", totalProfit },
                        { "total_cost", totalCost },
                        { "total_revenue", totalRevenue }
                    };

                    Invoice invoice = new Invoice
                    {
                        prefix = "KAP-",
                        sequence = InvoiceNo,
                        date = DateTime.Today,
                        time = DateTime.Now.ToString("hh:mm:ss tt"),
                        customer_id = cbCustomerID.Text,
                        items = items,
                        total_profit = totalProfit,
                        total_cost = totalCost,
                        total_revenue = totalRevenue
                    };

                    await _mongoConnector.InsertDocumentAsync("invoices", newInvoice);

                    // generate the PDF document
                    pdfGenerator.GeneratePdf(invoice);

                    MessageBox.Show("Invoice saved successfully.");
                }
            }

            Clear();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Hasini\OneDrive\Documents\invoices";
            string outputPath = $"{filePath}\\{"KAP-" + lblInvoiceNoData.Text}.pdf";
        }
    }
}
