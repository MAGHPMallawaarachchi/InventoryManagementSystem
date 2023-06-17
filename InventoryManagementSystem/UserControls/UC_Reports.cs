using InventoryManagementSystem.DataModels;
using MongoDB.Driver;
using System.Configuration;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.Layout.Properties;
using Image = iText.Layout.Element.Image;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_Reports : UserControl
    {
        UIHelper UIHelper = new UIHelper();
        ShowMessage showMessage = new ShowMessage();

        private readonly MongoConnector _mongoConnector;
        public UC_Reports()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void UC_Reports_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();

            var filter = Builders<Invoice>.Filter.Empty;
            OverviewLoad(filter);
            BestSellingCategoriesLoad(filter);
            BestSellingItemsLoad(filter);

            RefreshData();
        }

        public void ComboBoxLoad()
        {
            cbFilters.Items.Add("All time");
            cbFilters.Items.Add("Last week");
            cbFilters.Items.Add("Last month");
            cbFilters.Items.Add("Last year");
            cbFilters.SelectedIndex = 0;
            cbFilters.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void OverviewLoad(FilterDefinition<Invoice> filter)
        {
            // Disable automatic row height adjustment
            dgvOverview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //get all the invoices from the collection invoices          
            var invoices = await _mongoConnector.GetInvoices(filter);

            decimal TotalProfit = 0m;
            decimal TotalRevenue = 0m;
            int salesCount = 0;

            // Process the result
            foreach (var invoice in invoices)
            {
                TotalProfit += invoice.total_profit;
                TotalRevenue += invoice.total_revenue;
                salesCount++;
            }

            // Clear the existing rows in the DataGridView
            dgvOverview.Rows.Clear();

            dgvOverview.Rows.Add(new object[] {
                "Rs."+TotalProfit.ToString("N2"),
                "Rs."+TotalRevenue.ToString("N2"),
                salesCount
            });

            dgvOverview.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;

            foreach (DataGridViewRow row in dgvOverview.Rows)
            {
                row.Height = 50;
            }

            // set the current cell to null to prevent the first row from being selected
            dgvOverview.CurrentCell = null;

        }

        private async void BestSellingCategoriesLoad(FilterDefinition<Invoice> filter)
        {
            // Disable automatic row height adjustment
            dgvBestSellingCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            category.Width = 300;

            //get all the items from the collection items
            var categories = await _mongoConnector.GetUniqueCategories();

            // create a list to store the data
            var data = new List<object[]>();

            var invoices = await _mongoConnector.GetInvoices(filter);

            foreach (var category in categories)
            {
                decimal ProfitByCategory = 0m;
                decimal RevenueByCategory = 0m;
                decimal CostByCategory = 0m;
                int QuantitySoldByCategory = 0;

                foreach (var invoice in invoices)
                {
                    var items = await _mongoConnector.GetInvoiceItems((int)invoice.sequence!);

                    foreach (var item in items)
                    {
                        var ThisItem = await _mongoConnector.GetByPartNumber(item.part_number!);
                        if (ThisItem.category == category)
                        {
                            CostByCategory += item.cost;
                            ProfitByCategory += item.profit;
                            RevenueByCategory += item.revenue;
                            QuantitySoldByCategory += (int)item.quantity!;
                        }
                    }
                }

                // add the data to the list
                data.Add(new object[] {
                    category,
                    QuantitySoldByCategory,
                    RevenueByCategory.ToString("N2"),
                    ProfitByCategory.ToString("N2")
                });
            }

            // sort the data in descending order of QuantitySoldByCategory
            data.Sort((x, y) => ((int)y[1]).CompareTo((int)x[1]));

            // display only the first three rows
            data = data.Take(3).ToList();

            // display the data in the DataGridView
            dgvBestSellingCategories.Rows.Clear();
            foreach (var row in data)
            {
                dgvBestSellingCategories.Rows.Add(row);
            }

            foreach (DataGridViewRow row in dgvBestSellingCategories.Rows)
            {
                row.Height = 50;
            }

            // set the current cell to null to prevent the first row from being selected
            dgvBestSellingCategories.CurrentCell = null;

        }

        private async void BestSellingItemsLoad(FilterDefinition<Invoice> filter)
        {
            // Disable automatic row height adjustment
            dgvBestSellingItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            var invoices = await _mongoConnector.GetInvoices(filter);

            // create a list to store the data
            var data = new List<object[]>();

            // Group the invoice items by part number and sum their revenue and profit
            var itemGroups = invoices.SelectMany(i => i.items!)
                                     .GroupBy(item => item.part_number!)
                                     .Select(group => new
                                     {
                                         PartNumber = group.Key,
                                         Quantity = group.Sum(item => item.quantity),
                                         Revenue = group.Sum(item => item.revenue),
                                         Profit = group.Sum(item => item.profit)
                                     });

            foreach (var itemGroup in itemGroups)
            {
                var item = await _mongoConnector.GetByPartNumber(itemGroup.PartNumber);

                data.Add(new object[] {
                    itemGroup.PartNumber,
                    item.brand!,
                    item.category!,
                    itemGroup.Quantity,
                    item.quantity_in_hand!,
                    itemGroup.Revenue.ToString("N2"),
                    itemGroup.Profit.ToString("N2")
                });
            }

            // sort the data in descending order of QuantitySoldByCategory
            data.Sort((x, y) => ((int)y[3]).CompareTo((int)x[3]));

            // display the data in the DataGridView
            dgvBestSellingItems.Rows.Clear();
            foreach (var row in data)
            {
                dgvBestSellingItems.Rows.Add(row);
            }

            foreach (DataGridViewRow row in dgvBestSellingItems.Rows)
            {
                row.Height = 50;
            }


            // set the current cell to null to prevent the first row from being selected
            dgvBestSellingItems.CurrentCell = null;

        }

        private Color GetHeaderForeColor(int columnIndex)
        {
            // Define the RGB values for each column header forecolor.
            int[][] rgbValues = { new[] { 10, 73, 156 }, new[] { 132, 94, 188 }, new[] { 225, 145, 51 } };

            // Create a new color using the RGB values for the current column header forecolor.
            return Color.FromArgb(rgbValues[columnIndex % rgbValues.Length][0],
                                  rgbValues[columnIndex % rgbValues.Length][1],
                                  rgbValues[columnIndex % rgbValues.Length][2]);
        }

        private void Panel1_StyleChanged(object sender, EventArgs e)
        {
            UIHelper.UpdatePanelRegion(Panel1);
        }

        private void Panel2_SizeChanged(object sender, EventArgs e)
        {
            UIHelper.UpdatePanelRegion(Panel2);
        }

        private void Panel3_SizeChanged(object sender, EventArgs e)
        {
            UIHelper.UpdatePanelRegion(Panel3);
        }

        private void dgvOverview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check if the current cell is a column header cell.
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {

                // Set the forecolor of the current header cell.
                e.CellStyle.ForeColor = GetHeaderForeColor(e.ColumnIndex);

                // Paint the background of the current header cell.
                e.PaintBackground(e.CellBounds, false);

                // Paint the content of the current header cell.
                e.PaintContent(e.CellBounds);

                // Prevent the default painting of the header cell.
                e.Handled = true;
            }
        }

        public void RefreshData()
        {
            UIHelper.UpdatePanelRegion(Panel2);
            UIHelper.UpdatePanelRegion(Panel1);
            UIHelper.UpdatePanelRegion(Panel3);
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDefinition<Invoice> filter;

            if (cbFilters.SelectedIndex == 0)
            {
                filter = Builders<Invoice>.Filter.Empty;
            }
            else if (cbFilters.SelectedIndex == 1)
            {
                filter = Builders<Invoice>.Filter.Gte("date", DateTime.Now.AddDays(-7));
            }
            else if (cbFilters.SelectedIndex == 2)
            {
                filter = Builders<Invoice>.Filter.Gte("date", DateTime.Now.AddMonths(-1));
            }
            else if (cbFilters.SelectedIndex == 3)
            {
                filter = Builders<Invoice>.Filter.Gte("date", DateTime.Now.AddYears(-1));
            }
            else
            {
                // default case
                filter = Builders<Invoice>.Filter.Empty;
            }

            OverviewLoad(filter);
            BestSellingCategoriesLoad(filter);
            BestSellingItemsLoad(filter);
        }

        private string FileName()
        {
            DateTime today = DateTime.Today;
            DateTime lastWeek = today.AddDays(-7);
            DateTime lastMonth = today.AddMonths(-1);
            DateTime lastYear = today.AddYears(-1);

            string fileName;

            if (cbFilters.SelectedIndex == 0)
            {
                fileName = "All Time - " + today.ToString("yyyy-MM-dd");
            }
            else if (cbFilters.SelectedIndex == 1)
            {
                fileName = lastWeek.ToString("yyyy-MM-dd") + "-" + today.ToString("yyyy-MM-dd");
            }
            else if (cbFilters.SelectedIndex == 2)
            {
                fileName = lastMonth.ToString("yyyy-MM-dd") + "-" + today.ToString("yyyy-MM-dd");
            }
            else if (cbFilters.SelectedIndex == 3)
            {
                fileName = lastYear.ToString("yyyy-MM-dd") + "-" + today.ToString("yyyy-MM-dd");
            }
            else
            {
                // default case
                fileName = today.ToString("yyyy-MM-dd");
            }

            return fileName;
        }

        private void GeneratePdfReport()
        {
            string filePath = @"C:\Users\Hasini\OneDrive\Documents\Kamal Auto Parts\reports";

            string fileName = FileName();

            string outputPath = $"{filePath}\\{fileName}.pdf";

            // create a new PDF document
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(outputPath));

            // create a new document instance using the PDF document
            Document document = new Document(pdfDoc);

            // add a title to the document
            Paragraph title = new Paragraph("Report " + fileName);
            title.SetFontSize(25);
            document.Add(title);

            // create three tables
            Table table1 = new Table(new float[] { 2, 2, 1 })
                .UseAllAvailableWidth();

            Table table2 = new Table(new float[] { 2, 1, 2, 2 })
                .UseAllAvailableWidth();

            Table table3 = new Table(new float[] { 2, 2, 2, 1, 1, 2, 2 })
                .UseAllAvailableWidth();

            // add header row to the table1
            table1.AddHeaderCell("Total Profit");
            table1.AddHeaderCell("Revenue");
            table1.AddHeaderCell("Sales");

            // add data rows to the table1
            foreach (DataGridViewRow row in dgvOverview.Rows)
            {
                string? total_profit = row.Cells["total_profit"].Value.ToString();
                string? revenue = row.Cells["revenue"].Value.ToString();
                string? sales = row.Cells["sales"].Value.ToString();

                table1.AddCell(total_profit);
                table1.AddCell(revenue);
                table1.AddCell(sales);
            }

            // add header row to the table2
            table2.AddHeaderCell("Category");
            table2.AddHeaderCell("Qty Sold");
            table2.AddHeaderCell("Revenue");
            table2.AddHeaderCell("Profit");

            // add data rows to the table2
            foreach (DataGridViewRow row in dgvBestSellingCategories.Rows)
            {
                string? category = row.Cells["category"].Value.ToString();
                string? cat_qty_sold = row.Cells["cat_quantity_sold"].Value.ToString();
                string? cat_revenue = row.Cells["cat_revenue"].Value.ToString();
                string? cat_profit = row.Cells["cat_profit"].Value.ToString();

                table2.AddCell(category);
                table2.AddCell(cat_qty_sold);
                table2.AddCell(cat_revenue);
                table2.AddCell(cat_profit);
            }

            // add header row to the table3
            table3.AddHeaderCell("Part Number");
            table3.AddHeaderCell("Brand");
            table3.AddHeaderCell("Category");
            table3.AddHeaderCell("Qty Sold");
            table3.AddHeaderCell("Qty in hand");
            table3.AddHeaderCell("Revenue");
            table3.AddHeaderCell("Profit");

            // add data rows to the table3
            foreach (DataGridViewRow row in dgvBestSellingItems.Rows)
            {
                string? part_number = row.Cells["part_number"].Value.ToString();
                string? brand = row.Cells["brand"].Value.ToString();
                string? category_ = row.Cells["category_"].Value.ToString();
                string? qty_sold = row.Cells["qty_sold"].Value.ToString();
                string? qty_in_hand = row.Cells["qty_in_hand"].Value.ToString();
                string? revenue_ = row.Cells["revenue_"].Value.ToString();
                string? profit_ = row.Cells["profit_"].Value.ToString();

                table3.AddCell(part_number);
                table3.AddCell(brand);
                table3.AddCell(category_);
                table3.AddCell(qty_sold);
                table3.AddCell(qty_in_hand);
                table3.AddCell(revenue_);
                table3.AddCell(profit_);
            }

            // add the table3 to the document

            Paragraph table1_title = new Paragraph("Overview");
            title.SetFontSize(20);
            document.Add(table1_title);

            document.Add(table1);

            Paragraph table2_title = new Paragraph("Best Selling Categories");
            title.SetFontSize(20);
            document.Add(table2_title);

            document.Add(table2);

            Paragraph table3_title = new Paragraph("Best Selling Items");
            title.SetFontSize(20);
            document.Add(table3_title);

            document.Add(table3);

            // close the document
            document.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Form? parentForm = this.FindForm();

            try
            {
                GeneratePdfReport();
                showMessage.ShowSuccessMessage("Report downloaded!", parentForm!);
            }
            catch (Exception ex)
            {
                showMessage.ShowErrorMessage(ex.Message, parentForm!);
            }
        }
    }
}
