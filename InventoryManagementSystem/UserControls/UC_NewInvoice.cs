using InventoryManagementSystem.DataModels;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;
using System.Drawing.Drawing2D;


namespace InventoryManagementSystem.UserControls
{

    public partial class UC_NewInvoice : UserControl
    {
        UIHelper uIHelper = new UIHelper();
        Dashboard dashboard = new Dashboard();
        ShowMessage showMessage = new ShowMessage();

        private readonly MongoConnector _mongoConnector;
        private decimal total = 0;

        public UC_NewInvoice()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private async void UC_Invoices_Load(object sender, EventArgs e)
        {
            uIHelper.UpdatePanelRegion(Panel2);
            uIHelper.UpdatePanelRegion(Panel1);
            uIHelper.UpdatePanelRegion(Panel3);


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
            description.Width = 450;

            qty.ValueType = typeof(int);
            qty.Width = 150;

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

        private void Panel1_SizeChanged(object sender, EventArgs e)
        {
            uIHelper.UpdatePanelRegion(Panel1);
        }

        private void Panel2_SizeChanged(object sender, EventArgs e)
        {
            uIHelper.UpdatePanelRegion(Panel2);
        }

        private void Panel3_SizeChanged(object sender, EventArgs e)
        {
            uIHelper.UpdatePanelRegion(Panel3);
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

                // Check for duplicate selections
                if (IsDuplicateComboBoxSelection(e.RowIndex))
                {
                    Form? parentForm = this.FindForm();
                    showMessage.ShowErrorMessage(selectedPartNumber + " already exists in the invoice", parentForm!);
                    // Reset the cell value to default
                    dgvItems.Rows[e.RowIndex].Cells["part_no"].Value = "-- Part Number --";
                }
                else if (!string.IsNullOrEmpty(selectedPartNumber) && selectedPartNumber != "-- Part Number --")
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

                string? selectedPartNumber = dgvItems.Rows[e.RowIndex].Cells[dgvItems.Columns["part_no"].Index].Value.ToString();
                Form? parentForm = this.FindForm();

                if (int.TryParse(dgvItems.Rows[e.RowIndex].Cells["qty"].Value?.ToString(), out qtyValue))
                {
                    if (await CheckStock(selectedPartNumber!, qtyValue) == false)
                    {
                        showMessage.ShowErrorMessage("Insufficient stock for item " + selectedPartNumber, parentForm!);
                        dgvItems.Rows[e.RowIndex].Cells["qty"].Value = 0;
                    }
                    else
                    {
                        decimal qtyDecimalValue = new decimal(qtyValue);
                        decimal unitPrice = Convert.ToDecimal(dgvItems.Rows[e.RowIndex].Cells["unit_price"].Value);
                        amount = unitPrice * qtyDecimalValue;
                    }
                }
                dgvItems.Rows[e.RowIndex].Cells["amount"].Value = amount.ToString("N2");
                UpdateTotal();

            }

        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                decimal amount = Convert.ToDecimal(row.Cells["amount"].Value);
                total += amount;
            }
            lblTotalData.Text = total.ToString("N2");
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

            lblTotalData.Text = "";
        }

        private async Task<bool> CheckStock(string part_number, int qty)
        {
            bool IsSufficient = true;

            if (CheckEmptyRows() == false)
            {
                var item = await _mongoConnector.GetByPartNumber(part_number);

                if (item != null && item.quantity_in_hand < qty)
                {
                    IsSufficient = false;
                }
            }

            return IsSufficient;
        }

        private bool ValidateInputs()
        {
            bool IsValid = true;

            if (cbCustomerID.SelectedIndex == 0)
            {
                Form? parentForm = this.FindForm();
                showMessage.ShowErrorMessage("Please select a customer!", parentForm!);
                IsValid = false;
            }
            else if (AnyRowHasZeroQty() == true)
            {
                Form? parentForm = this.FindForm();
                showMessage.ShowErrorMessage("Quantity cannot be zero!", parentForm!);
                IsValid = false;
            }

            return IsValid;
        }

        private async Task<int> GetInvoiceNumber()
        {
            int invoiceNo = 10000;
            long count = await _mongoConnector.GetCollection<Invoice>("invoices").CountDocumentsAsync(FilterDefinition<Invoice>.Empty);

            if (count > 0)
            {
                invoiceNo = await _mongoConnector.GetLastInvoice() + 1;
            }

            return invoiceNo;
        }

        private bool CheckEmptyRows()
        {
            bool hasEmptyRows = false;
            int emptyRowCount = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                string? partNo = row.Cells["part_no"].Value?.ToString();

                if (string.IsNullOrEmpty(partNo) || partNo == "-- Part Number --")
                {
                    emptyRowCount++;
                }
            }

            if (emptyRowCount == dgvItems.Rows.Count)
            {
                hasEmptyRows = true;
            }

            return hasEmptyRows;
        }

        private async Task<bool> updateStock(string part_number, decimal decimal_qty, int quantity)
        {
            bool IsUpdated;

            var document = await _mongoConnector.GetByPartNumber(part_number);

            decimal updateTotalCost = (decimal)(document!.total_cost + (decimal_qty * document.buying_price))!;
            decimal updateTotalRevenue = (decimal)(document.total_revenue + (decimal_qty * document.unit_price))!;
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

            try
            {
                await collectionNew.UpdateOneAsync(filter, new BsonDocument("$set", updateDoc));
                IsUpdated = true;
            }
            catch
            {
                IsUpdated = false;
            }

            return IsUpdated;
        }

        private bool AnyRowHasZeroQty()
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                int qty = Convert.ToInt32(row.Cells["qty"].Value);
                if (qty == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsDuplicateComboBoxSelection(int rowIndex)
        {
            string? selectedPartNumber = dgvItems.Rows[rowIndex].Cells[dgvItems.Columns["part_no"].Index].Value?.ToString();

            if (string.IsNullOrEmpty(selectedPartNumber) || selectedPartNumber == "-- Part Number --")
            {
                // Ignore empty or default selection
                return false;
            }

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Index == rowIndex)
                {
                    // Skip the current row
                    continue;
                }

                string? partNumber = row.Cells[dgvItems.Columns["part_no"].Index].Value?.ToString();

                if (selectedPartNumber == partNumber)
                {
                    // Found a duplicate
                    return true;
                }
            }

            return false;
        }


        private async void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            Form? parentForm = this.FindForm();

            if (CheckEmptyRows())
            {
                showMessage.ShowErrorMessage("Please enter at least one item!", parentForm!);
            }
            else if (ValidateInputs())
            {
                int InvoiceNo = await GetInvoiceNumber();

                decimal totalProfit = 0;
                decimal totalCost = 0;
                decimal totalRevenue = 0;

                var invoiceItems = new List<BsonDocument>();
                List<InvoiceItem> items = new List<InvoiceItem>();

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    string? partNumber = row.Cells["part_no"].Value?.ToString();
                    int quantity = Convert.ToInt32(row.Cells["qty"].Value);
                    decimal amount = Convert.ToDecimal(row.Cells["amount"].Value);

                    if (partNumber == "-- Part Number --" || partNumber == null)
                    {
                        continue;
                    }
                    else if (await CheckStock(partNumber, quantity))
                    {
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

                        await updateStock(partNumber, DecimalQty, quantity);
                    }

                }

                // create an instance of the PdfGenerator class
                PdfGenerator pdfGenerator = new PdfGenerator();

                var newInvoice = new BsonDocument
                    {
                        { "prefix", "KAP-" },
                        { "sequence", InvoiceNo },
                        { "invoice_no", "KAP-"+InvoiceNo },
                        { "date", DateTime.Today },
                        { "time", DateTime.Now.ToString("hh:mm:ss tt") },
                        { "customer_id", cbCustomerID.Text },
                        { "items", new BsonArray(invoiceItems) },
                        { "total_profit", totalProfit },
                        { "total_cost", totalCost },
                        { "total_revenue", totalRevenue },
                        { "status", "Pending" }
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

                try
                {
                    await _mongoConnector.InsertDocumentAsync("invoices", newInvoice);

                    // generate the PDF document
                    pdfGenerator.GeneratePdfInvoice(invoice);

                    showMessage.ShowSuccessMessage("Invoice saved successfully!", parentForm!);
                }
                catch (Exception ex)
                {
                    showMessage.ShowErrorMessage(ex.Message, parentForm!);
                }

                Clear();
            }

        }

    }
}
