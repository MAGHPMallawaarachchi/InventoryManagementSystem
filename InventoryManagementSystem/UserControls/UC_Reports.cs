using System.Configuration;
using System.Drawing.Drawing2D;

namespace InventoryManagementSystem.UserControls
{
    public partial class UC_Reports : UserControl
    {
        private readonly MongoConnector _mongoConnector;
        public UC_Reports()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"]!;
            _mongoConnector = new MongoConnector(connectionString, "InventoryManagementSystem");
        }

        private void UC_Reports_Load(object sender, EventArgs e)
        {
            BestSellingItemsLoad();
            BestSellingCategoriesLoad();
            OverviewLoad();

            UpdatePanelRegion(Panel2);
            UpdatePanelRegion(Panel1);
            UpdatePanelRegion(Panel3);
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

        public async void OverviewLoad()
        {
            // Disable automatic row height adjustment
            dgvOverview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //get all the invoices from the collection invoices          
            var invoices = await _mongoConnector.GetAllInvoices();

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

        public async void BestSellingCategoriesLoad()
        {
            // Disable automatic row height adjustment
            dgvBestSellingCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //get all the items from the collection items
            var categories = await _mongoConnector.GetUniqueCategories();

            // create a list to store the data
            var data = new List<object[]>();

            // Process the result
            foreach (var category in categories)
            {
                var items = await _mongoConnector.GetItemsByCategory(category);

                // decimal CostByCategory = 0m;
                decimal ProfitByCategory = 0m;
                decimal RevenueByCategory = 0m;
                int QuantitySoldByCategory = 0;

                foreach (var item in items)
                {
                    //CostByCategory += item.total_cost;
                    ProfitByCategory += item.total_profit;
                    RevenueByCategory += item.total_revenue;
                    QuantitySoldByCategory += (int)item.quantity_sold!;
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

        public async void BestSellingItemsLoad()
        {
            // Disable automatic row height adjustment
            dgvBestSellingItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //get all the items from the collection items
            var documents = await _mongoConnector.GetBestSellingItems();

            // Process the result
            foreach (var document in documents)
            {

                dgvBestSellingItems.Rows.Add(new object[] {
                    document.part_number!,
                    document.brand!,
                    document.category!,
                    document.quantity_sold!,
                    document.quantity_in_hand!,
                    document.total_revenue.ToString("N2"),
                    document.total_profit.ToString("N2")
                });
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
    }
}
